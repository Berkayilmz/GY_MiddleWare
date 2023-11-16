namespace GY_MiddleWare
{
    public class Notes
    {
        /* 
         ----- Middleware Nedir? -------
        -web uygulamasına client'tan gelen request'e karşılık verilecek response'a kadar arada farklı işlemler gerçekleştirmek ve sürecin gidişatına yön vermek istediğimiz durumlarda middleware kullanırız.
        -Bir başka deyişle request ile response arasında işlemler yapıyorsak buna ara yazılım (middleware) denilir.
        -Request geldi, arada bazı işlemler yaptık ve respons'u geri döndürdük. İşte bu "arada yapılan işlemler" middleware'dır.
        
        Request     Middleware    Response
        ------->    --------->    -------->

        -Middleware'ler sarmal bir şekilde çalışır. Bir middleware tetiklendiği zaman kendisi sona ermeden bşaka bir middleware'ı tetikler ve onu bekler.

                    Middleware1         Middleware2        Middleware3
        Request     
        ----------> //logic
                    next();    --------> //logic
                                         next();   --------> //logic
                                                             next();
                                                                     
                                                                            
                                                             //more logic           
                                                                   |         
                                         //more    <----------------
                                           logic
                                             |
                     //more    <--------------
                       logic
                         |
        Response         |
        <-----------------


        ------- Asp.NET Core Uygulamasında MiddleWare nerelerde oluşturulur ------------

        -Startup dosyasındaki:
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env){}
        fonskiyonu içerisindeki bütün çalışmalar middleware'dır

        -Yine configure metodu içerisinde çağırılır.
        -Asp.Net Core mimarisinde tüm middleware'ler Use adiyle başlar.

        --Middleware'lerde tetiklenme sırası ÖNEMLİDİR!!!!!!! 


        
        -------------- HAZIR MIDDLEWARE'LER --------------

        -- Run: Run fonksiyonu kendisinden sonra gelen middleware'i tetiklemez. Kendisinden sonraki middleware tetiklenmeyeceği için çıktıyı direkt orada verecektir. Bu etkiye Short Circuit (Kısa Devre) denir.

        -- Use: Run metoduna nazaran, devreye girdikten sonra ki süreçte sıradaki middleware'i çağırmakta ve normal middleware işlevi bittikten sonra geriye dönüp devam edebilen bir yapıya sahiptir.

        -- Map: Bazen middleware'i talep gönderen path'e göre filtrelemek isteyebiliriz. Bunun için Use ya da Run fonksiyonlarında if kontrolü sağlayabilir ya da Map metodu ile daha profesyonel işlem yapabiliriz. Filtreleme için kullanılır.

        -- MapWhen: Map metodu ile sadece request'in yapıldığı path'e göre filtreleme yapılırken, MapWhen metodu ile gelen request'in herhangi bir özelliğine göre bir filtreleme yapılabilir.



        ------------------ CUSTOM MİDDLEWARE OLUŞTURMA --------------------

        -Ayrı bir sınıfta davranışsal tasarlayabilir ve extention olarak startup.cs dosyasında çağırabiliriz.
        -Request geldiğinde Hello yazdıran bir MW oluşturalım.





        */


    }
}
