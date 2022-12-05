package com.example.myapplication;

public class Ogrenci {
    private int sira;
    private String adSoyad,numara,bolum;

    public Ogrenci(int sira, String adSoyad, String numara, String bolum) {
        this.sira = sira;
        this.adSoyad = adSoyad;
        this.numara = numara;
        this.bolum = bolum;
    }

    @Override
    public String toString() {
        return "Sıra:"+sira+"-"+adSoyad+" "+numara+" "+bolum;
    }
}
