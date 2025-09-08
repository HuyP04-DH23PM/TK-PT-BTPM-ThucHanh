using System;

// Demo Factory Method Pattern trong tình huống thực tế: Document & Page
class MainApp
{
    static void Main()
    {
        // Lưu ý: Constructor của Document sẽ tự động gọi Factory Method CreatePages()

        // Tạo mảng Document gồm 2 loại tài liệu: Resume và Report
        Document[] documents = new Document[2];
        documents[0] = new Resume();
        documents[1] = new Report();

        // Hiển thị danh sách các trang của từng Document
        foreach (Document document in documents)
        {
            Console.WriteLine("\n" + document.GetType().Name + " --");
            foreach (Page page in document.Pages)
            {
                Console.WriteLine(" " + page.GetType().Name);
            }
        }

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
