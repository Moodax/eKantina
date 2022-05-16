package com.example.ekantina

import android.app.PendingIntent.getActivity
import android.content.Intent
import android.os.Bundle
import android.view.Menu
import android.view.View
import android.widget.Toast
import android.widget.Toast.LENGTH_LONG
import com.google.android.material.bottomnavigation.BottomNavigationView
import androidx.appcompat.app.AppCompatActivity
import androidx.navigation.findNavController
import androidx.navigation.ui.AppBarConfiguration
import androidx.navigation.ui.setupActionBarWithNavController
import androidx.navigation.ui.setupWithNavController

import androidx.fragment.app.Fragment
import androidx.fragment.app.FragmentManager
import androidx.fragment.app.FragmentTransaction
import androidx.navigation.NavDeepLinkBuilder
import androidx.navigation.Navigation
import androidx.navigation.fragment.NavHostFragment
import com.example.ekantina.R.id.*
import com.example.ekantina.databinding.ActivityMainBinding


class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val navView: BottomNavigationView = binding.navView

        val navController = findNavController(nav_host_fragment_activity_main)
        // Passing each menu ID as a set of Ids because each
        // menu should be considered as top level destinations.
        val appBarConfiguration = AppBarConfiguration(
            setOf(
                navigation_home, navigation_dashboard
            )
        )

        navView.setupWithNavController(navController)
    }
    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        val inflater = menuInflater
        inflater.inflate(R.menu.menu, menu)
        return super.onCreateOptionsMenu(menu)
    }

    fun sendvic(view: View) {
        val bundle = Bundle()
        bundle.putString("kategorija","sendvici")
        Navigation.findNavController(view).navigate(action_navigation_home_to_menuFragment,bundle)
    }
    fun pice(view: View) {
        val bundle = Bundle()
        bundle.putString("kategorija","pica")
        Navigation.findNavController(view).navigate(action_navigation_home_to_menuFragment,bundle)
    }
    fun grickalice(view: View) {
        val bundle = Bundle()
        bundle.putString("kategorija","slatkisi i grickalice")
        Navigation.findNavController(view).navigate(action_navigation_home_to_menuFragment,bundle)
    }
}