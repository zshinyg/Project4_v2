﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem {

	void Ability (IPlayer player);

	int Duration();

}

