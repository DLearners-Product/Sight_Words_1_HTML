using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class EnablerCmtsDB
{
    public string welcome;
    public string brain_gym_brain_buttons;
    public string introduction;
    public string flash_card_activity;
    public string brain_gym_ocean_breathing;
    public string word_search;
    public string read_along_sentences;
    public string working_memory_activity;
    public string goodbye;

    public EnablerCmtsDB()
    {
        welcome = Main_Blended.OBJ_main_blended.enablerComments[0];
        brain_gym_brain_buttons = Main_Blended.OBJ_main_blended.enablerComments[1];
        introduction = Main_Blended.OBJ_main_blended.enablerComments[2];
        flash_card_activity = Main_Blended.OBJ_main_blended.enablerComments[3];
        brain_gym_ocean_breathing = Main_Blended.OBJ_main_blended.enablerComments[4];
        word_search = Main_Blended.OBJ_main_blended.enablerComments[5];
        read_along_sentences = Main_Blended.OBJ_main_blended.enablerComments[6];
        working_memory_activity = Main_Blended.OBJ_main_blended.enablerComments[7];
        goodbye = Main_Blended.OBJ_main_blended.enablerComments[8];
    }
}