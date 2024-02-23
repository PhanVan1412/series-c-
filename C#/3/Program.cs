// See https://aka.ms/new-console-template for more information
// Nhập vào số năm và hiên thị năm theo âm lịch

string[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
string[] chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi" };
int nam, numberCan, numberChi;
string result = "";

Console.Write("Nhap vao nam ban can kiem tra: ");
nam = int.Parse(Console.ReadLine());

numberCan = nam % 10;
numberChi = nam % 12;

for (int i  = 0; i < 10;  i++)
{
    if (i == numberCan)
    {
        result += can[i];
    }
}
for (int i = 0; i < 12;  i++)
{
    if (i == numberChi)
    {
        result = result + " " + chi[i];
    }
}
Console.WriteLine("Năm {0} là năm {1}", nam, result);
