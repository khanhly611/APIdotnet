## Hướng dẫn Front-end kết nối API

API được xây dựng bằng ASP.NET Core Web API.

### Endpoint

```http
POST /api/products
```

URL đầy đủ:

```http
https://localhost:7218/api/products
```

### Dữ liệu gửi lên

Front-end cần gửi dữ liệu ở định dạng JSON:

```json
{
    "name": "Laptop Dell",
    "price": 15000000
}
```

### Header

```http
Content-Type: application/json
```

### Quy trình kết nối

#### Bước 1: Người dùng nhập thông tin sản phẩm

Ví dụ:

* Tên sản phẩm: Laptop Dell
* Giá sản phẩm: 15000000

#### Bước 2: Front-end tạo dữ liệu JSON

```json
{
    "name": "Laptop Dell",
    "price": 15000000
}
```

#### Bước 3: Front-end gửi HTTP POST request

Gửi request đến:

```http
https://localhost:7218/api/products
```

#### Bước 4: API kiểm tra dữ liệu

* Name bắt buộc và tối thiểu 3 ký tự.
* Price bắt buộc và phải lớn hơn 0.

#### Bước 5: API trả kết quả

Nếu dữ liệu hợp lệ:

```json
{
    "message": "Thêm sản phẩm thành công",
    "data": {
        "name": "Laptop Dell",
        "price": 15000000
    }
}
```

Nếu dữ liệu không hợp lệ:

```json
{
    "message": "Dữ liệu không hợp lệ",
    "errors": {
        "Name": [
            "Tên sản phẩm phải có ít nhất 3 ký tự"
        ]
    }
}
```

### Ví dụ kết nối bằng JavaScript

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
.then(data => console.log(data));
```
