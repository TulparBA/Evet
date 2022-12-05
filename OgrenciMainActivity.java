package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private ListView listView;
    //private String[] sehirler={"Ankara","İstanbul","İzmir","Eskişehir","Niğde","Artvin","Mersin"}
    /*private static int SUCCESS_CODE=200;*/
    private ArrayList<Ogrenci> ogrenciler=new ArrayList();
    private ArrayAdapter<Ogrenci> adaptor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listView=findViewById(R.id.listView);
        /*Ogrenci ogr1=new Ogrenci(1,"Ahmet Yılmaz","221211","BILGP");*/
        ogrenciler.add(new Ogrenci(1,"Ahmet Yılmaz","221211","BILGP"));
        ogrenciler.add(new Ogrenci(2,"Esra Demir","221212","BILGP"));
        ogrenciler.add(new Ogrenci(3,"Mehmet Kaya","221213","BILGP"));
        ogrenciler.add(new Ogrenci(4,"Burak Arzuman","221214","BILGP"));
        /*
        sehirler.size();
        */
        adaptor = new ArrayAdapter<>(getApplicationContext(), android.R.layout.simple_list_item_1,ogrenciler);
        //NASIL BİR ŞABLONA ; HANGİ(DİZİ YA DA ARRAYLIST) BİLGİLERİ
        listView.setAdapter(adaptor);
        /*
        sehirler.add("Niğde");
        sehirler.remove("Niğde");
        */
    }

}Ma
