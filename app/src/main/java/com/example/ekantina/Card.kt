package com.example.ekantina

import android.graphics.Bitmap
import android.media.Image

data class Card (
        var id :Int,
        var ime_proizvoda: String,
        var kategorija_proizvoda: String,
        var cijena_proizvoda :Int,
        var opis_proizvoda: String,
        var slika: Bitmap

)