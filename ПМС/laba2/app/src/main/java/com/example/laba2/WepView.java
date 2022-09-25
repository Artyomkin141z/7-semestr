package com.example.laba2;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.os.Bundle;
import android.webkit.WebView;


public class WepView extends Activity {
    private WebView webView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_wep_view);

        webView = findViewById(R.id.webView);
        webView.loadUrl("https://www.google.ru/");
    }
}