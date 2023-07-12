# Developer Notes

Hazırlanan bu projede bazı eksiklikler vardır

1 - Fluent Validation
2 - Aspects (Performance, Cache, Autofac etc.)
3 - CrossCuttingConcers
4 - MiddleWares

FluentValidation ile nesneleri belli kurallara göre eklenebilmesini ayarlamak gerekirdi
Aspectler ile Performans Transaction ve Cache yönetimi gibi olayların yönetilmesi sağlanmalıydı

Bunların yapılması projenin teslim süresini geciktireceğinden bu yapılar implemente edilmemiştir.

Projeyi test edebilmeniz için path = Hyper-Backend/resources/postman yolu ile belirtilen postman klasöründe Hyper projesi için hazırlanmış Http isteklerini içeren postman collectionu bulunmaktadır bu collection'ı postmanda import ederek kullanabilirsiniz.

Genel olarak proje istenen yapının mantığından kopmama şartıyla farklı tasarlanmıştır.

Projenin teslim tarihi en geç 14/07/2023 Cuma günü olduğundan projenin yetişmesi amacıyla bazı kullanılması gereken yapılar es geçilmiştir. Bu proje istenildiği kadar genişletililebilir ve geliştirilebilir.

Projeyi çalıştırmak için windows kullanıyorsanız bash terminalinde şu komudu yazın: `run/bkh-web.sh`

Docker ve Sonar özellikleri daha sonra getirilecek.
