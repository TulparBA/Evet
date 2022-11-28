package com.example.myapplication;

import static android.widget.Toast.LENGTH_LONG;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
private Button siparisB;
private CheckBox sucukCB,soganCB,ybiberCB,kbiberCB,mantarCB;
private RadioButton inceHamur,kalinHamur,kucukBoy,ortaBoy,buyukBoy;
private int toplam=0;
    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    siparisB=findViewById(R.id.siparisB);
    sucukCB=findViewById(R.id.sucukCB);
    soganCB=findViewById(R.id.soganCB);
    ybiberCB=findViewById(R.id.ybiberCB);
    kbiberCB=findViewById(R.id.kbiberCB);
    mantarCB=findViewById(R.id.mantarCB);
    inceHamur=findViewById(R.id.inceHamur);
    kalinHamur=findViewById(R.id.kalinHamur);
    kucukBoy=findViewById(R.id.kucukBoy);
    ortaBoy=findViewById(R.id.ortaBoy);
    buyukBoy=findViewById(R.id.buyukBoy);


    siparisB.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if(sucukCB.isChecked())
            toplam+=5;
        if(soganCB.isChecked())
            toplam+=3;
        if(ybiberCB.isChecked())
            toplam+=2;
        if(kbiberCB.isChecked())
            toplam+=2;
        if(mantarCB.isChecked())
            toplam+=3;
        else if(kucukBoy.isChecked())
            toplam+=20;
        else if(ortaBoy.isChecked())
            toplam+=25;
        else if(buyukBoy.isChecked())
                    toplam+=30;


        if (kalinHamur.isChecked())
                   toplam+=2;

        Toast.makeText(getApplicationContext(), "Toplam fiyat:"+toplam,LENGTH_LONG).show();
    }
}
