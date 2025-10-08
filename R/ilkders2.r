isim <- "Ahmet"
yas <- 25

# print() fonksiyonu, içine verilen değeri ekrana yazdırır.
print(isim)

# sum() fonksiyonu, sayıların toplamını bulur.
toplam <- sum(5, 10, 15)

# Sayısal bir vektör (numeric vector)
notlar <- c(85, 92, 78, 65, 95)

# Karakter vektörü (character vector)
ogrenciler <- c("Ali", "Veli", "Ayşe", "Fatma", "Can")

# Vektörler üzerinde matematiksel işlemler yapmak çok kolaydır
# Her nota 5 puan ekleyelim:
yeni_notlar <- notlar + 5
print(yeni_notlar)

# Öğrenciler ve notlardan bir data frame oluşturalım
sinif_listesi <- data.frame(
    Ad = ogrenciler,
    Not = notlar
)

# Data frame'i görüntüleyelim
print(sinif_listesi)

# Sadece ilk birkaç satırı görmek için head() kullanılır
head(sinif_listesi)

# Data frame'in yapısını (sütun tipleri, satır/sütun sayısı vb.) görmek için
str(sinif_listesi)

# iris veri setinin özet istatistiklerini görelim
summary(iris)

# Ortalama (mean), standart sapma (sd) gibi temel istatistikleri hesaplayalım
# Çiçeklerin taç yaprağı uzunluğunun (Petal.Length) ortalaması
ortalama_tac_yaprak <- mean(iris$Petal.Length)
print(ortalama_tac_yaprak)

# iris veri setindeki taç yaprağı uzunluğunun dağılımını gösteren bir histogram
hist(iris$Petal.Length,
    main = "Iris Taç Yaprağı Uzunluğu Dağılımı",
    xlab = "Taç Yaprağı Uzunluğu (cm)",
    ylab = "Frekans",
    col = "lightblue"
)

# Sepal (çanak yaprak) uzunluğu ve genişliği arasında bir serpilme grafiği (scatter plot)
plot(
    x = iris$Sepal.Length, y = iris$Sepal.Width,
    main = "Sepal Uzunluğu vs. Genişliği",
    xlab = "Sepal Uzunluğu",
    ylab = "Sepal Genişliği"
)
