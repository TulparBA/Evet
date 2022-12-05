package com.example.myapplication;

public class HavaDurumu {
    private String sehir,durum;
    private double sicaklik;

    public HavaDurumu(String sehir,String durum, double sicaklik) {
        this.sehir = sehir;
        this.durum = durum;
        this.sicaklik = sicaklik;
    }

    @Override
    public String toString() {

        return "Şehir:"+sehir+" "+"Durum:"+durum+" "+"Sıcaklık"+sicaklik;
    }
}
