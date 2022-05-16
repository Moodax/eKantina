package com.example.ekantina.ui.home

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ListView
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import com.example.ekantina.R
import com.example.ekantina.databinding.FragmentHomeBinding
import android.widget.ArrayAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ekantina.Card

import com.example.ekantina.DatabaseAccess
import com.google.android.material.snackbar.Snackbar

import androidx.recyclerview.widget.RecyclerView.ViewHolder

class HomeFragment : Fragment() {
    private var listView: ListView? = null
    private lateinit var homeViewModel: HomeViewModel

    // This property is only valid between onCreateView and
    // onDestroyView.




    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        val view: View = inflater.inflate(
            R.layout.fragment_home, container,
            false)
        /*var listView=view.findViewById<ListView>(R.id.listView)
        val databaseAccess = DatabaseAccess.getInstance(view.context)
        databaseAccess.open()
        val quotes = databaseAccess.card
        databaseAccess.close()

        val adapter: ArrayAdapter<Card> =
            ArrayAdapter<Card>(view.context, android.R.layout.simple_list_item_1, quotes)
        listView.setAdapter(adapter)*/

        return view
    }

}