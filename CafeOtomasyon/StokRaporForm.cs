using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CafeOtomasyon
{
    public partial class StokRaporForm : Form
    {
        public StokRaporForm()
        {
            InitializeComponent();
        }

        private void StokRaporForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string sorgu = "SELECT UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);

                string[] alanlar = { "UrunAd", "Birim", "SatisFiyat", "StokMiktari", "Kategori" };
                string[] basliklar = { "Ürün Adı", "Birim", "Satış Fiyatı", "Stok Miktarı", "Kategori" };

                reportViewer1.LocalReport.DataSources.Clear();
                using (StringReader sr = new StringReader(RaporTasarimiOlustur(alanlar, basliklar, "STOK LİSTESİ")))
                {
                    reportViewer1.LocalReport.LoadReportDefinition(sr);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok raporu oluşturulurken hata oluştu: " + ex.Message);
            }
        }

        private string RaporTasarimiOlustur(string[] alanlar, string[] basliklar, string raporBasligi)
        {
            StringBuilder kolonlar = new StringBuilder();
            StringBuilder baslikHucreleri = new StringBuilder();
            StringBuilder detayHucreleri = new StringBuilder();
            StringBuilder kolonUyeleri = new StringBuilder();
            StringBuilder fields = new StringBuilder();

            for (int i = 0; i < alanlar.Length; i++)
            {
                kolonlar.Append("<TablixColumn><Width>3cm</Width></TablixColumn>");
                kolonUyeleri.Append("<TablixMember />");
                fields.Append("<Field Name=\"" + alanlar[i] + "\"><DataField>" + alanlar[i] + "</DataField><rd:TypeName>System.String</rd:TypeName></Field>");

                baslikHucreleri.Append(@"<TablixCell><CellContents><Textbox Name=""Baslik" + i + @"""><CanGrow>true</CanGrow><KeepTogether>true</KeepTogether><Paragraphs><Paragraph><TextRuns><TextRun><Value>" + basliklar[i] + @"</Value><Style><FontWeight>Bold</FontWeight></Style></TextRun></TextRuns></Paragraph></Paragraphs><Style><Border><Style>Solid</Style></Border><BackgroundColor>LightGrey</BackgroundColor><PaddingLeft>2pt</PaddingLeft><PaddingRight>2pt</PaddingRight><PaddingTop>2pt</PaddingTop><PaddingBottom>2pt</PaddingBottom></Style></Textbox></CellContents></TablixCell>");
                detayHucreleri.Append(@"<TablixCell><CellContents><Textbox Name=""Detay" + i + @"""><CanGrow>true</CanGrow><KeepTogether>true</KeepTogether><Paragraphs><Paragraph><TextRuns><TextRun><Value>=Fields!" + alanlar[i] + @".Value</Value></TextRun></TextRuns></Paragraph></Paragraphs><Style><Border><Style>Solid</Style></Border><PaddingLeft>2pt</PaddingLeft><PaddingRight>2pt</PaddingRight><PaddingTop>2pt</PaddingTop><PaddingBottom>2pt</PaddingBottom></Style></Textbox></CellContents></TablixCell>");
            }

            string genislik = (alanlar.Length * 3).ToString(System.Globalization.CultureInfo.InvariantCulture) + "cm";

            return @"<?xml version=""1.0"" encoding=""utf-8""?>
<Report xmlns=""http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition"" xmlns:rd=""http://schemas.microsoft.com/SQLServer/reporting/reportdesigner"">
  <Body>
    <ReportItems>
      <Textbox Name=""RaporBasligi""><CanGrow>true</CanGrow><KeepTogether>true</KeepTogether><Paragraphs><Paragraph><TextRuns><TextRun><Value>" + raporBasligi + @"</Value><Style><FontSize>16pt</FontSize><FontWeight>Bold</FontWeight></Style></TextRun></TextRuns><Style><TextAlign>Center</TextAlign></Style></Paragraph></Paragraphs><Top>0cm</Top><Left>0cm</Left><Height>0.8cm</Height><Width>" + genislik + @"</Width><Style><Border><Style>None</Style></Border></Style></Textbox>
      <Tablix Name=""Tablix1""><TablixBody><TablixColumns>" + kolonlar.ToString() + @"</TablixColumns><TablixRows><TablixRow><Height>0.7cm</Height><TablixCells>" + baslikHucreleri.ToString() + @"</TablixCells></TablixRow><TablixRow><Height>0.6cm</Height><TablixCells>" + detayHucreleri.ToString() + @"</TablixCells></TablixRow></TablixRows></TablixBody><TablixColumnHierarchy><TablixMembers>" + kolonUyeleri.ToString() + @"</TablixMembers></TablixColumnHierarchy><TablixRowHierarchy><TablixMembers><TablixMember /><TablixMember><Group Name=""Details"" /></TablixMember></TablixMembers></TablixRowHierarchy><DataSetName>DataSet1</DataSetName><Top>1cm</Top><Left>0cm</Left><Height>1.3cm</Height><Width>" + genislik + @"</Width><Style><Border><Style>None</Style></Border></Style></Tablix>
    </ReportItems>
    <Height>3cm</Height>
    <Style />
  </Body>
  <Width>" + genislik + @"</Width>
  <Page><PageHeight>29.7cm</PageHeight><PageWidth>21cm</PageWidth><LeftMargin>1cm</LeftMargin><RightMargin>1cm</RightMargin><TopMargin>1cm</TopMargin><BottomMargin>1cm</BottomMargin><ColumnSpacing>0.13cm</ColumnSpacing><Style /></Page>
  <DataSources><DataSource Name=""DataSource1""><ConnectionProperties><DataProvider>System.Data.DataSet</DataProvider><ConnectString>/* Local Connection */</ConnectString></ConnectionProperties><rd:DataSourceID>11111111-1111-1111-1111-111111111111</rd:DataSourceID></DataSource></DataSources>
  <DataSets><DataSet Name=""DataSet1""><Query><DataSourceName>DataSource1</DataSourceName><CommandText>/* Local Query */</CommandText></Query><Fields>" + fields.ToString() + @"</Fields></DataSet></DataSets>
  <rd:ReportUnitType>Cm</rd:ReportUnitType>
  <rd:ReportID>22222222-2222-2222-2222-222222222222</rd:ReportID>
</Report>";
        }

    }
}
