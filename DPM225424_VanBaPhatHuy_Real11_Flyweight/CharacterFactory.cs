/// <summary>
/// Lớp 'FlyweightFactory' (Quản lý các đối tượng Flyweight ký tự)
/// </summary>
public class CharacterFactory
{
    // Từ điển lưu trữ các đối tượng Character đã được tạo (để dùng lại)
    private Dictionary<char, Character> characters = new Dictionary<char, Character>();

    public Character GetCharacter(char key)
    {
        // Khởi tạo chậm (lazy initialization) – chỉ tạo khi cần
        Character character = null;

        // Nếu đã có trong từ điển thì lấy ra
        if (characters.ContainsKey(key))
        {
            character = characters[key];
        }
        else
        {
            // Nếu chưa có, tạo mới tùy theo ký tự
            switch (key)
            {
                case 'A': character = new CharacterA(); break;
                case 'B': character = new CharacterB(); break;
                // Có thể mở rộng thêm các ký tự khác
                case 'Z': character = new CharacterZ(); break;
            }
            // Thêm đối tượng mới vào danh sách để lần sau dùng lại
            characters.Add(key, character);
        }
        return character;
    }
}