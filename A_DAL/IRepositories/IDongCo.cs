using A_DAL.DomaninClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IDongCo
    {
        public bool add(dongCo dongCo);
        public bool update(dongCo dongCo);
        public bool delete (dongCo dongCo);
        public List<dongCo> GetAll();
    }
/*    Ghi chú về giao diện:
Giống như các lớp trừu tượng, các giao diện không thể được sử dụng để tạo đối tượng(trong ví dụ trên, không thể tạo đối tượng "IAnimal" trong lớp Chương trình)
Các phương thức giao diện không có phần thân - phần thân được cung cấp bởi lớp "triển khai"
Khi triển khai một giao diện, bạn phải ghi đè tất cả các phương thức của nó
Các giao diện có thể chứa các thuộc tính và phương thức, nhưng không chứa các trường/biến
Các thành viên giao diện theo mặc định abstractvà public
Một giao diện không thể chứa hàm tạo(vì nó không thể được sử dụng để tạo đối tượng)
Tại sao và khi nào nên sử dụng giao diện?
1) Để đạt được bảo mật - ẩn một số chi tiết nhất định và chỉ hiển thị các chi tiết quan trọng của một đối tượng(giao diện).

2) C# không hỗ trợ "đa kế thừa" (một lớp chỉ có thể kế thừa từ một lớp cơ sở). Tuy nhiên, nó có thể đạt được với các giao 
        diện, bởi vì lớp có thể thực hiện nhiều giao diện. Lưu ý: Để triển khai nhiều giao diện, hãy phân tách chúng bằng dấu phẩy (xem ví dụ bên dưới).
*/

}
