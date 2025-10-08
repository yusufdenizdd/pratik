# 1ekim

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
show(x)
print(x)
x

# veri türü öğrenmek
class(x)
a <- "veri madenciliği"

# tür dönüşümleri
# R'da numeric default olarak double'dır
as.integer()
as.numeric()

# hata verecektir
durum <- TRUE
as.numeric(durum)

durum <- FALSE
durum <- as.numeric(durum)

is.numeric(durum)

# is.integer
x <- as.integer(100)
is.integer(x)

# değişkenin türünü doğrudan öğrenmek istiyorsak typeof()

typeof(x)
x <- as.character(x)
typeof(x)

# Değişken türünü doğrudan öğrenmek istiyorsak typof()
x <- 125
as.character(x)
# hafızada tumadık: aş. şekilde dene
x <- as.character(x)
# veritipini test edek
typeof(x)

typof(sonuc)



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
show(iris)
# view(adult)
iris
# tüm transactionlar gözüküyor

# en üstteki satırları görüntüle
head(iris)
head(iris, 10)


# 2.hazır veri kümeleri
data()
show(Groceries)
show(Adult)
view(Adult)
Adult

attributes(iris)

attributes(iris)$names()

colnames(iris)
row.names(iris)

# satır sayısı
ncol(iris)

# sütun sayısı
nrow(iris)

# özet bilgi
str(iris)


# install.packages("arules")
# install.packages("caret")
# yüklü olan paketlerin görüntülenmesi: search()
# kütüphanelerin yüklenmesi: library(arules)
# mevcut çalışma alanımızda ne var: ls()
# çalışma dizinini görüntüle getwd()
# çalışma dizinini değiştir setwd('dosyayolu')

# 3. R Paketler
# syntax install.packages
install.packages("arules")

install.packages("caret")


# ara yüzden Tools->Install Packages


# yüklüolan kütüphanelerinin görüntülenmesi
search()


# paketlerin oturuma tanıtılması
# kütüphanelerin yüklenmesi
library(arules)




# 4. Çalışma Alanı
# Mevcut çalışma alanımızda neler var
ls()


# çalışma diziini göürntüle
getwd()


# çalışma dizinini değiştir
# setwd('C:\Users\gkara\Dozuments\R\www')


# sorular
# 1- bir paket yüklendikten sonra ne olur?
# 2- x=45 6. değişkeni yapıp bu değişkenşerin tümünü integara dönüştür
# 3-Bir paket yüklendikten sonra R oturumuna nasıl tanıtılır
# 4-R da mevcut çalışma alanını görüntüle
# 5-a b c isimli nesneleri tanımşla
# 6- R çalışma alanı C bla workspace
