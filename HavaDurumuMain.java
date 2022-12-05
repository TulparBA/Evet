package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    private ListView listView;
    private ArrayList<HavaDurumu> havadurumu=new ArrayList();
    private ArrayAdapter<HavaDurumu> adaptor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listView=findViewById(R.id.listView);
        havadurumu.add(new HavaDurumu("Ankara","Güneşli",24.05));
        havadurumu.add(new HavaDurumu("İstanbul","Parçalı Bulutlu",21));
        havadurumu.add(new HavaDurumu("İzmir","Bulutlu",18.14));
        havadurumu.add(new HavaDurumu("Artvin","Sağnak Yağışlı",10));
        adaptor = new ArrayAdapter<>(getApplicationContext(), android.R.layout.simple_list_item_1,havadurumu);
        listView.setAdapter(adaptor);
    }

}
