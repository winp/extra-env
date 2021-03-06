﻿using System;
using System.Collections.Generic;

namespace App {
	class Params {

		/// <summary>
		/// Indicates mode to use for getting or setting environment variable.
		/// </summary>
		public EnvironmentVariableTarget mode = EnvironmentVariableTarget.User;
		/// <summary>
		/// This includes the subcommand, and its input arguments.
		/// </summary>
		public string[] args = new string[0];
	}
}
