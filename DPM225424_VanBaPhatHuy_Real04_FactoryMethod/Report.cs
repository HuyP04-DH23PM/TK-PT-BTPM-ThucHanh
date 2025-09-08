// 'Report' là một ConcreteCreator (cụ thể hóa Document)
// Nó override phương thức Factory Method để tạo ra các trang đặc thù cho Report
class Report : Document
{
    // Cài đặt Factory Method
    public override void CreatePages()
    {
        // Mỗi Report sẽ bao gồm các trang sau:
        Pages.Add(new IntroductionPage());   // Giới thiệu
        Pages.Add(new ResultsPage());        // Kết quả
        Pages.Add(new ConclusionPage());     // Kết luận
        Pages.Add(new SummaryPage());        // Tóm tắt
        Pages.Add(new BibliographyPage());   // Tài liệu tham khảo
    }
}
