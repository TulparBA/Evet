package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    private EditText sayi1ET,sayi2ET;
    double sonuc,sayi1,sayi2;
    private TextView sonucTV;
    private Button toplaB,cikarB,carpB,bolB;
    String str1,str2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        sayi1ET=findViewById(R.id.sayi1ET);
        sayi2ET=findViewById(R.id.sayi2ET);
        sonucTV=findViewById(R.id.sonucTV);
        toplaB=findViewById(R.id.toplaB);
        cikarB=findViewById(R.id.cikarB);
        carpB=findViewById(R.id.carpB);
        bolB=findViewById(R.id.bolB);

        toplaB.setOnClickListener(new OrtakDinleyici());
        cikarB.setOnClickListener(new OrtakDinleyici());
        carpB.setOnClickListener(new OrtakDinleyici());
        bolB.setOnClickListener(new OrtakDinleyici());

    }

    class OrtakDinleyici implements View.OnClickListener {
        @Override
        public void onClick(View v) {
         sayi1=Double.parseDouble(sayi1ET.getText().toString());
         sayi2=Double.parseDouble(sayi2ET.getText().toString());
         if (v.getId()==toplaB.getId())
            sonuc=sayi1+sayi2;
         else if(v.getId()==cikarB.getId())
             sonuc=sayi1-sayi2;
         else if(v.getId()==carpB.getId())
             sonuc=sayi1*sayi2;
         else if(v.getId()==bolB.getId())
             sonuc=sayi1/sayi2;
         sonucTV.setText("="+sonuc);
        }
    }
}
