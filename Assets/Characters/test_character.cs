using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Test", menuName = "Characters/TestCharacter", order = 1)]
public class test_character : BaseCharacter
{
    public test_character(int maxHealth, List<BaseSpell> spells) : base(maxHealth, spells)
    {

    }
}
