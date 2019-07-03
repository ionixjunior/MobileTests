package br.com.ionixjunior.appjava;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.Scanner;

public class MainActivity extends AppCompatActivity {
    private Button _btnLoadData;
    private TextView _lblData;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        _btnLoadData = this.findViewById(R.id.btnLoadData);
        _lblData = this.findViewById(R.id.lblData);

        _btnLoadData.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Thread thread = new Thread(new Runnable() {
                    @Override
                    public void run() {
                        StringBuilder response = new StringBuilder();

                        try {
                            URL url = new URL("https://mobiletests.getsandbox.com/ping");

                            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
                            connection.setRequestMethod("GET");
                            connection.setDoOutput(true);
                            connection.connect();

                            Scanner scanner = new Scanner(url.openStream());
                            while (scanner.hasNext()) {
                                response.append(scanner.next());
                            }
                        } catch (MalformedURLException e) {
                            e.printStackTrace();
                        } catch (IOException e) {
                            e.printStackTrace();
                        }

                        _lblData.setText(response.toString());
                    }
                });

                thread.start();
            }
        });
    }
}
