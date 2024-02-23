// See https://aka.ms/new-console-template for more information
// 1. LinQ là một query language được dùng để truy vấn dữ liệu từ các nguồn dữ liệu khác nhau (data source)
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;

var productIds = new int[6] { 1, 3, 4, 2, 5, 6 };
var productEvenIds = from productId in productIds
                     where productId % 2 == 0
                     select productId;

foreach(var productId in productEvenIds)
{
    Console.WriteLine("Product Id {0} which is even.", productId);
}


/* 2. --- Mệnh đề trong LinQ ---
 * Trong câu query sẽ có 3 mệnh đề (clause) from, where, select tương tự như viết query trong database
 * from: nguồn dữ liệu (data source)
 * where: điều kiện để lọc dữ liệu. (filter data)
 * select: lấy kết quả
 */

/* 3. --- Các cách để viết query LinQ ---
 * Query  Syntax khá giống với cách viết câu query trong SQL
 * Method Syntax sử dụng các hàm hỗ trợ của LinQ của C# .net
 */

var productEvenIds2 = productIds.Where(productId => productId % 2 == 0)
    .Select(productId => productId);

foreach(var productId in productEvenIds2)
{
    Console.WriteLine("Product Id 2 {0} which is even.", productId);
}


/*4. --- Lambda Expressions trong LinQ --- 
 * Cách viết function ở mệnh đề Where như là 1 arrow function
 * Lambda expressions được dùng để tạo ra một function ẩn danh 
 * productId => productId % 2 == 0 là một biểu thức lambda (Lambda expression) 
 * với productId là tham số đầu vào (input parameter) của function ẩn danh
 */

