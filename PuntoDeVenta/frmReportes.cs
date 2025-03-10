using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using PuntoDeVenta.clases;
using System.Data;
using System.Drawing.Imaging;
using Color = iText.Kernel.Colors.Color;
using Image = iText.Layout.Element.Image;
using Path = System.IO.Path;

namespace PuntoDeVenta
{
    public partial class frmReportes : Form
    {

        public frmReportes()
        {
            InitializeComponent();
            List<string> list = new List<string>()
            {
                new ("Lista de clientes"),
                new ("Ventas por productos"),
                new ("Ventas por clientes"),
                new ("Lista de productos"),
                new ("Ventas por mes")
            };



            cbReporte.DataSource = list;
            cbReporte.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar archivo PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ubicacion = saveFileDialog.FileName;

                    GuardarReporte(ubicacion);
                    MessageBox.Show("Reporte guardado exitosamente.");
                }
            }
        }

        private void GuardarReporte(string ubicacion)
        {

            switch (cbReporte.SelectedIndex)
            {
                case 0:
                    Reportes db = new Reportes();
                    DataTable dt = db.ListaClientes();
                    string encabezado = "Reporte de \nLista de clientes";

                    CrearPDF(ubicacion, dt, encabezado);
                    
                    break;

                case 1:
                    Reportes db1 = new Reportes();
                    DataTable dt1 = db1.VentasProducto();
                    string encabezado1 = "Reporte de \nVentas por productos";

                    CrearPDF(ubicacion, dt1, encabezado1);
                    break;

                case 2:
                    Reportes db2 = new Reportes();
                    DataTable dt2 = db2.VentasClientes();
                    string encabezado2 = "Reporte de \nVentas por clientes";

                    CrearPDF(ubicacion, dt2, encabezado2);
                    break;

                case 3:
                    Reportes db3 = new Reportes();
                    DataTable dt3 = db3.ListaProductos();
                    string encabezado3 = "Reporte de \nLista de productos";

                    CrearPDF(ubicacion, dt3, encabezado3);
                    break;

                case 4:
                    Reportes db4 = new Reportes();
                    DataTable dt4 = db4.VentasMes();
                    string encabezado4 = "Reporte de \nVentas por mes";

                    CrearPDF(ubicacion, dt4, encabezado4);
                    break;

                default:
                    break;
            }
        }

        private void CrearPDF(string ubicacion, DataTable dt, string encabezado) {
            PdfWriter writer = new PdfWriter(ubicacion);
            PdfDocument pdf = new PdfDocument(writer);
            Document documento = new Document(pdf, PageSize.A4);

            documento.Add(CrearEncabezado(encabezado));

            Table tabla0 = new Table(dt.Columns.Count);

            tabla0.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (DataColumn columna in dt.Columns)
            {
                tabla0.AddHeaderCell(CrearCelda(columna.ColumnName, true));
            }

            foreach (DataRow fila in dt.Rows)
            {
                foreach (var celda in fila.ItemArray)
                {
                    tabla0.AddCell(CrearCelda(celda.ToString(), false));
                }
            }

            documento.Add(tabla0);

            documento.Close();
        }

        private Table CrearEncabezado(string reporte) {
            Table tablaEncabezado = new Table(new float[] { 70, 30 });
            tablaEncabezado.SetWidth(UnitValue.CreatePercentValue(100));

            Paragraph titulo = new Paragraph(reporte)
                .SetFontSize(30)
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontColor(new DeviceRgb(38, 70, 83))
                .SetMultipliedLeading(1f);
            Cell tituloCelda = new Cell().Add(titulo)
                .SetBorder(Border.NO_BORDER)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE);
            tablaEncabezado.AddCell(tituloCelda);

            Bitmap logoBitmap = Properties.Resources.logo128;

            string logoTemporal = Path.Combine(Path.GetTempPath(), "logo_temporal.png");
            logoBitmap.Save(logoTemporal, ImageFormat.Png);

            ImageData imageData = ImageDataFactory.Create(logoTemporal);
            Image logo = new Image(imageData)
                .SetWidth(60)
                .SetHeight(60)
                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            Paragraph nombre = new Paragraph("TecniCell")
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBold()
                .SetFontColor(new DeviceRgb(38, 70, 83)); ;

            Paragraph fecha = new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"))
                .SetFontSize(8)
                .SetTextAlignment(TextAlignment.CENTER);

            Cell detalleCelda = new Cell()
                .Add(logo)
                .Add(nombre)
                .Add(fecha);
            detalleCelda.SetBorder(Border.NO_BORDER);
            detalleCelda.SetTextAlignment(TextAlignment.CENTER);
            detalleCelda.SetVerticalAlignment(VerticalAlignment.MIDDLE);
            tablaEncabezado.AddCell(detalleCelda);

            return tablaEncabezado;
        }

        private Cell CrearCelda(string contenido, bool encabezado)
        {
            Cell celda = new Cell();
            celda.SetTextAlignment(TextAlignment.LEFT);
            celda.SetVerticalAlignment(VerticalAlignment.MIDDLE);
            celda.SetPadding(5);


            Paragraph parrafo = new Paragraph(contenido ?? string.Empty);
            parrafo.SetFontSize(10f);
            if (encabezado)
            {
                parrafo.SetFont(PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD));
                parrafo.SetFontColor(new DeviceRgb(255, 255, 255));
                celda.SetBackgroundColor(new DeviceRgb(38, 70, 83));
                celda.SetBorder(new SolidBorder(new DeviceRgb(255, 255, 255), 1));
            }
            else
            {
                parrafo.SetFont(PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN));
                celda.SetBorder(new SolidBorder(new DeviceRgb(38, 70, 83), 1));
            }

            celda.Add(parrafo);
            return celda;
        }

        private void cbReporte_DropDownClosed(object sender, EventArgs e)
        {
            switch (cbReporte.SelectedIndex)
            {
                case 0:
                    Reportes db = new Reportes();
                    DataTable dt = db.ListaClientes();
                    dgvVer.DataSource = dt;
                    break;

                case 1:
                    Reportes db1 = new Reportes();
                    DataTable dt1 = db1.VentasProducto();
                    dgvVer.DataSource = dt1;
                    break;

                case 2:
                    Reportes db2 = new Reportes();
                    DataTable dt2 = db2.VentasClientes();
                    dgvVer.DataSource = dt2;
                    break;

                case 3:
                    Reportes db3 = new Reportes();
                    DataTable dt3 = db3.ListaProductos();
                    dgvVer.DataSource = dt3;
                    break;

                case 4:
                    Reportes db4 = new Reportes();
                    DataTable dt4 = db4.VentasMes();
                    dgvVer.DataSource = dt4;
                    break;

                default:
                    break;
            }
        }
    }
}
