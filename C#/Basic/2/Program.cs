// See https://aka.ms/new-console-template for more information
// Tính xếp loại học sinh dựa vào điểm 3 môn toán văn anh được nhập từ bàn phím
float diemToan, diemVan, diemAnh;
float tb;
string result = "";

Console.WriteLine("Chuong trinh tinh diem trung binh dua vao 3 mon: Toan - Van - Anh");

Console.Write("Nhap diem mon toan: " );
diemToan = float.Parse(Console.ReadLine());

Console.Write("Nhap diem mo van: ");
diemVan = float.Parse(Console.ReadLine());

Console.Write("Nhap diem mon anh: ");
diemAnh = float.Parse(Console.ReadLine());

tb = (diemToan + diemVan + diemAnh)/3; 

if (tb > 5 && tb < 6.5)
{
    result = "Trung binh";
    
} else if (tb >= 6.5 && tb < 8) {
    result = "Kha";
} else if(tb >= 8) {
    result = "Gioi";
} else
{
    result = "Yeu";
}

Console.WriteLine("Diem toan  = {0}, Van = {1} Anh = {2}", diemToan, diemVan, diemAnh);
Console.WriteLine("Xep loai cua ban la: " + result);
