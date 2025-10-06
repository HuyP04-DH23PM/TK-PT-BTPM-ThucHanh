// Định nghĩa giao diện chung cho việc xây dựng gói sản phẩm nông dược
abstract class Builder
{
    public abstract void BuildPhanBon();     // Xây dựng phần phân bón
    public abstract void BuildThuocTruSau(); // Xây dựng phần thuốc trừ sâu
    public abstract Product GetResult();     // Lấy gói hoàn chỉnh
}
