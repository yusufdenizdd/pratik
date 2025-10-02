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

durum <- TRUE
as.numeric(durum)

durum <- FALSE
durum <- as.numeric(durum)

is.numeric(durum)

x <- as.integer(100)
is.integer(x)
typeof(x)
x <- as.character(x)
typeof(x)

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
