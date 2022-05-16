package com.example.ekantina;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.util.Log;

import java.util.ArrayList;
import java.util.List;

public class DatabaseAccess {
    private SQLiteOpenHelper openHelper;
    private SQLiteDatabase database;
    private static DatabaseAccess instance;

    /**
     * Private constructor to aboid object creation from outside classes.
     *
     * @param context
     */
    private DatabaseAccess(Context context) {
        this.openHelper = new DatabaseConnection(context);
    }

    /**
     * Return a singleton instance of DatabaseAccess.
     *
     * @param context the Context
     * @return the instance of DabaseAccess
     */
    public static DatabaseAccess getInstance(Context context) {
        if (instance == null) {
            instance = new DatabaseAccess(context);
        }
        return instance;
    }

    /**
     * Open the databases connection.
     */
    public void open() {
        this.database = openHelper.getWritableDatabase();
    }

    /**
     * Close the databases connection.
     */
    public void close() {
        if (database != null) {
            this.database.close();
        }
    }

    /**
     * Read all quotes from the databases.
     *
     * @return a List of quotes
     */
    public List<Card> getCard(String uvjet) {
        List<Card> list = new ArrayList<Card>();
        Cursor cursor = database.rawQuery("SELECT * FROM proizvodi WHERE TRIM(kategorija_proizvoda) = '"+uvjet.trim()+"'", null);
        cursor.moveToFirst();

        while (!cursor.isAfterLast()) {
            Log.d("aa", cursor.getString(1));
            byte[] byteArray = cursor.getBlob(5);
            Bitmap bm = BitmapFactory.decodeByteArray(byteArray, 0 ,byteArray.length);
            list.add( new Card(
            cursor.getInt(0),        //id
            cursor.getString(1),        // ime proizvoda
            cursor.getString(2),     // kategorija proizvoda
            cursor.getInt(3),     // cijena proizvoda
            cursor.getString(4),        // opis
            bm
            ));
            cursor.moveToNext();
        }
        cursor.close();
        return list;
    }
}
