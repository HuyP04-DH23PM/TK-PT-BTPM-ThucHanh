// 'Resume' là một ConcreteCreator (cụ thể hóa Document)
// Nó override phương thức Factory Method để tạo ra các trang đặc thù cho Resume
class Resume : Document
{
    // Cài đặt Factory Method
    public override void CreatePages()
    {
        // Mỗi Resume sẽ bao gồm các trang sau:
        Pages.Add(new SkillsPage());      // Kỹ năng
        Pages.Add(new EducationPage());   // Học vấn
        Pages.Add(new ExperiencePage());  // Kinh nghiệm
    }
}
