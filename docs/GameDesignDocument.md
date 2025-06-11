# Oyun Tasarım Belgesi (GDD)

## 1. Oyun Genel Bakış
- **Başlık (Geçici):** Living World RPG
- **Tür:** Açık dünya fantastik RPG (sihir ve anomalilerle)
- **Platform:** PC (Unity 3D URP)
- **Mod:** Tek oyuncu (ileride çok oyunculu potansiyel)
- **Hedef Zorluk:** Kolay – Orta

## 2. Konsept & Atmosfer
- **Tema:** Fantastik ve sihirli bir dünya, doğal manzaralarla iç içe anomaliler barındıran.
- **Atmosfer:** Ormanlar, vadiler ve dağlar gibi doğal ortamlar, arada mistik fırtınalar ve parlayan bitkilerle bozulmuş bölgeler.
- **Dünya Türü:** Kesintisiz açık dünya; bölgeler arası yükleme ekranı olmadan keşif.

## 3. Oyuncu Karakter & İlerleme
- **Karakter Seçimi:** Birden fazla arketip (örn. Savaşçı, Büyücü, Hırsız); ilk prototip Savaşçı.
- **Yetenek Bazlı İlerleme:** Tek bir “karakter seviyesi” yok. Her eylem veya yetenek (yürüme, koşma, zıplama, yakın dövüş, sihir) kendi XP’sini toplar ve kullanıldıkça gelişir.
  - *Örnek:* Yürüme yeteneği zamana bağlı XP kazanır; seviye atlayınca temel yürüme hızı artar.
- **Sınıfa Özel Yetenek Ağaçları:** Her arketipin dallanan bir yetenek ağacı (örn. Savaşçı için Ağırlık Darbeleri, Kalkan Teknikleri).
- **Dayanıklılık/Stamina:** Eylemler stamina tüketir; stamina yeteneği yükseldikçe maksimum stamina artar.

## 4. Temel Oynanış Döngüsü
1. **Keşfet:** Dünyada dolaş, anomali bölgelerini ve kaynakları bul.
2. **Etkileşim:** NPC’lerle konuş, görev al, diplomasi veya dövüş seçenekleri.
3. **Geliş:** Yetenek XP’si kazan, yetenek ağacında yeni düğümleri aç.
4. **Dünyayı Etkile:** NPC ilişkileri ve tamamlanan görevler gizli yan görevleri veya yeni bölge erişimini açar.
5. **Tekrarla:** Yeni alanlar keşfet, daha derin hikâyeler ve zorluklar ortaya çıkar.

## 5. Dünya Mekanikleri & Sistemler
- **Dinamik Gün-Gece Döngüsü** ve **Hava Durumu Sistemi** (yağmur, sis, fırtına) keşfi ve NPC rutinlerini etkiler.
- **Anomali Bölgeleri:** Öngörülemeyen sihirsel etkiler—geçici buff/debuff veya çevresel tehlikeler.
- **Kaynak Toplama & Üretim:** Bitki toplama, maden işletme; iksir, eşyalar ve büyülü kaplamalar yapma.
- **Kamp & Dinlenme Sistemi:** Kamp ateşi kurarak kaydetme, yemek tarifleriyle geçici buff’lar elde etme.
- **Envanter Sistemi & Eşya Seviyelendirme:** Karakterin envanterindeki eşyalar kullanım boyunca XP kazanır ve belirli seviyelere ulaştıklarında oyuncuya sürpriz bonuslar veya özel yetenekler kazandırır.

## 6. NPC’ler & Diplomasi
- **Faksiyonlar & Ün:** Birden fazla grup; işlemlerin ün puanını etkiler ve farklı görev ağları açar.
- **Günlük Rutinler:** NPC’ler pazar, han veya devriye gibi programlara uyar.
- **Diyalog Sistemi:** Yarn Spinner/Ink ile dallanan konuşmalar; seçimler görev ve ün üzerinde etki yapar.
- **Gizli Görevler:** Yüksek ün seviyesi gizli yan görevleri veya özel diyalogları açar.

## 7. Görevler & Hikâye Yapısı
- **Ana Hikâye:** Dünya anomalilerinin kaynağını keşfet ve dengeyi geri getir.
- **Yan Görevler:** Hem prosedürel hem de el yapımı görevler—kurtarma, hazine avı, bulmacalar.
- **Dallanıp Budaklanan Sonuçlar:** Kararlarına göre farklı sonlar, NPC dostluk/düşmanlıkları ve dünya durum değişiklikleri.

## 8. Kullanıcı Arayüzü & HUD
- **Sağlık & Stamina Çubukları:** TextMeshPro ile köşe UI’sında.
- **Yetenek XP Göstergeleri:** Karakter menüsünde her yetenek için mini çubuk.
- **Dünya Haritası:** Keşfettikçe açılan harita, hızlı seyahat noktaları.
- **Görev Günlüğü:** Aktif ve tamamlanan görevleri, ün değişimlerini takip eder.

## 9. Teknik Hususlar
- **Modüler Mimari:** Sistemler arayüzler (IInputService, IPhysicsService) üzerinden ayrılmış.
- **Veri Odaklı Tasarım:** Karakter istatistikleri, eşya tanımları, NPC rutinleri ScriptableObject veya JSON dosyalarında.
- **Sürüm Kontrol & İş Akışı:** GitHub repoda Kanban board ve issue-driven development.

## 10. Gelecek Genişletmeler
- **Çok Oyunculu Geçiş Planı:** Mantık katmanlarının soyutlanması, Mirror/Netcode for GameObjects uyumlu bileşenler.
- **Sezonluk Etkinlikler & Başarılar:** Zaman sınırlı dünya etkinlikleri, global sıralamalar.

---
*Belge, tüm temel oyun öğelerini yakalamak ve geliştirme sürecini yönlendirmek için hazırlandı.*  
