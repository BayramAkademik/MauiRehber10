# MauiRehber10
# Kamera veya Galeriden Resim ekleme eklenmiştir
#Platforms->Android->AndroidManifest.xml dosyasına aşağıdaki izinlerin ekli olduğuna dikkat edin.


``` <?xml version="1.0" encoding="utf-8"?>
` <manifest xmlns:android="http://schemas.android.com/apk/res/android">
` 	<application android:allowBackup="true" android:icon="@mipmap/appicon" android:supportsRtl="true"></application>
` 	<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
` 	<uses-permission android:name="android.permission.INTERNET" />
` 	<uses-permission android:name="android.permission.CAMERA" />
` 	<uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />
` 	<uses-permission android:name="android.permission.READ_MEDIA_IMAGES" />
` 	<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
` 	<uses-sdk />
` </manifest>
