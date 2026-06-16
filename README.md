Video: https://drive.google.com/file/d/1mHmm3jtMWVk3TRbVYVhMzOKSDqe5Pdy8/view?usp=sharing

## Hướng dẫn Front-end kết nối API

API cung cấp endpoint:

```http
POST /api/products
```

Địa chỉ API:

```http
https://localhost:7218/api/products
```

### Kết nối từ Web (JavaScript)

Sử dụng Fetch API để gửi dữ liệu JSON đến server:

```javascript
fetch("https://localhost:7218/api/products", {
    method: "POST",
    headers: {
        "Content-Type": "application/json"
    },
    body: JSON.stringify({
        name: "Laptop Dell",
        price: 15000000
    })
})
.then(response => response.json())
.then(data => console.log(data))
.catch(error => console.error(error));
```

### Kết nối từ Mobile (Flutter)

Sử dụng package `http` để gọi API:

```dart
import 'dart:convert';
import 'package:http/http.dart' as http;

Future<void> createProduct() async {
  final response = await http.post(
    Uri.parse('https://localhost:7218/api/products'),
    headers: {
      'Content-Type': 'application/json'
    },
    body: jsonEncode({
      'name': 'Laptop Dell',
      'price': 15000000
    }),
  );

  print(response.body);
}
```

### Lưu ý

* Front-end cần gửi dữ liệu ở định dạng JSON.
* Header phải có:

```http
Content-Type: application/json
```

* Khi triển khai thực tế, thay `localhost` bằng địa chỉ IP hoặc domain của máy chủ chứa API.
