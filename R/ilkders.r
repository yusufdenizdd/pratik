# 1ekim

# BİLGİ: Paket kurulumu ve kütüphanelerin çağrılması gibi işlemlerin
# kodun en başında yapılması, kodun okunabilirliği ve çalışması için en iyi pratiktir.
# Bu komutları sadece bir kere çalıştırmanız yeterlidir. Bilgisayarınıza bir kere kurulduktan sonra
# tekrar tekrar install.packages demenize gerek yoktur. Bu yüzden yorum satırı içine alıyorum.
# Paketleri SADECE BİR KERE kurmak için bu bölümü çalıştırın
# install.packages("arules", repos = "https://cloud.r-project.org")
# install.packages("caret", repos = "https://cloud.r-project.org")
# install.packages("lava", repos = "https://cloud.r-project.org") # Eksik olan paket
# Kütüphaneleri oturuma tanıtmak için library() kullanılır.
# Groceries ve Adult veri setlerini kullanabilmek için arules paketini en başta yüklüyoruz.
library(arules)
library(caret)



## Online R compiler to run R program online
## Print "Try programiz.pro" message

message <- "Try programiz.pro"
print(message)

# değişkenler ile işlem yapmak #

# sağa atama
x <- 12
x <<- 12
x <- 120

# sola atama
12 -> y

# yaratılan nesneleri görüntülemek
objects()
ls()

# mevcut nesneyi silmek
rm(x)
ls()

# birden fazla öğeyi silmek
x <- 4
rm(x, y)

# değişkenlerin içeriğini görüntülemek
x <- 4
show(x)
print(x)


# veri türü öğrenmek
class(x)
a <- "veri madenciliği"
class(a)

# tür dönüşümleri
# R'da numeric default olarak double'dır
# DÜZELTME: Bu fonksiyonlar bir argüman (değişken) olmadan tek başına çalışmaz.
# Örnek kullanım göstermek için bunları yorum satırı yapıyorum.
# as.integer()
# as.numeric()

# Örnek:
ornek_sayi <- 15.7
ornek_tamsayi <- as.integer(ornek_sayi) # 15 olarak dönüştürür
print(ornek_tamsayi)


durum <- TRUE
as.numeric(durum) # Bu satır dönüşümü yapar ama bir değişkene atamaz. Sonuç 1'dir.

durum <- FALSE
durum <- as.numeric(durum) # durum değişkeninin değeri artık 0 olur.

is.numeric(durum)

# is.integer
x <- as.integer(100)
is.integer(x)

# değişkenin türünü doğrudan öğrenmek istiyorsak typeof()

typeof(x)
x <- as.character(x)
typeof(x)

# DÜZELTME: Yorumdaki yazım hatası düzeltildi. typof -> typeof
# Değişken türünü doğrudan öğrenmek istiyorsak typeof()
x <- 125
as.character(x)
# hafızada tutmadık: aş. şekilde dene
x <- as.character(x)
# veritipini test edek
typeof(x)

# typeof(sonuc)



# mantıksalişlemler
a <- 125
b <- 200
a < b
b < a
a < b && a > 75
a < b && a < 75


# bu arada dersi kaçırdım

# hazır veri kümeleri
data()
# R ile gelen temel veri setlerinden birini gösterelim
show(iris)
# view(adult) # DÜZELTME: R'da fonksiyonlar büyük/küçük harfe duyarlıdır. Doğrusu View() şeklindedir.
iris
# tüm transactionlar gözüküyor

# en üstteki satırları görüntüle
head(iris)
head(iris, 10)


# 2.hazır veri kümeleri
# BİLGİ: Bu veri setleri "arules" paketi ile gelir.
# Bu yüzden kodun en başında library(arules) komutunu çalıştırdık.
data(Groceries)
data(Adult)

show(Groceries)
show(Adult)
# View(Adult)
# BİLGİ: 'transactions' nesneleri View() ile değil, inspect() ile incelenir.
# Tüm veriyi ekrana basmamak için head() ile ilk 10 satıra bakalım.
inspect(head(Adult, 10))
# DÜZELTME: view değil, View olacak (Büyük V harfi ile).
# RStudio gibi bir IDE'de çalıştırıldığında veri setini yeni bir sekmede tablo olarak açar.


attributes(iris)

# DÜZELTME: attributes(iris)$names() şeklinde bir kullanım doğrudan isimleri vermez.
# Sütun isimleri için doğru kullanım names(iris) veya colnames(iris) şeklindedir.
# attributes(iris)$names()
names(iris)
colnames(iris)

# DÜZELTME: row.names değil, rownames olmalı (boşluksuz ve küçük harfle).
rownames(iris)

# satır sayısı
# DÜZELTME: ncol sütun (column), nrow satır (row) sayısını verir. Yorumlar düzeltildi.
ncol(iris) # Sütun sayısı

# sütun sayısı
nrow(iris) # Satır sayısı

# özet bilgi
str(iris)

# 3. R Paketler
# BİLGİ: Bu komutlar en başa taşındı.
# install.packages("arules")
# install.packages("caret")


# ara yüzden Tools->Install Packages


# yüklüolan kütüphanelerinin görüntülenmesi
search()


# paketlerin oturuma tanıtılması
# kütüphanelerin yüklenmesi
# BİLGİ: Bu komut en başa taşındı.
# library(arules)




# 4. Çalışma Alanı
# Mevcut çalışma alanımızda neler var
ls()


# çalışma diziini göürntüle
getwd()


# çalışma dizinini değiştir
# DÜZELTME: R'da dosya yollarını belirtirken ters taksim (\) yerine düz taksim (/) kullanmalısınız.
# Aksi halde ters taksimi bir "kaçış karakteri" olarak algılar ve hata verir.
# setwd('C:/Users/gkara/Documents/R/www')


# sorular
# 1- bir paket yüklendikten sonra R oturumuna nasıl tanıtılır?
# 2- x=45 6. değişkeni yapıp bu değişkenşerin tümünü integara dönüştür
# 3-Bir paket yüklendikten sonra R oturumuna nasıl tanıtılır
# 4-R da mevcut çalışma alanını görüntüleyiniz
# 5-a b c isimli nesneler tanımlayınız (değer veriniz)
# 6- R çalışma alanı C bla workspace
# 7- R'ın mevcut çalışma alanını «C://belgeler/R/workspace» olarak belirleyiniz (yorum satırında yazın, kodu çalıştırmayın)
# 8- mevcut yaratılmış nesneleri görüntüleyiniz
