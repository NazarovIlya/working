﻿using Stopwach.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwach
{
  internal class Presenter
  {
    private bool state;
    private List<ICommand> commands;
    View view;
    Model model;
    public Presenter()
    {
      this.view = new View();
      this.model = new Model();
      model.Counter = 0;
      this.commands = new List<ICommand>()
      {
        new StartCommand(model, view),
        new PauseCommand(model, view),
        new StopCommand()
      };
    }

    public void StartStopwach()
    {
      while (true)
      {
        Console.Clear();
        int index = view.Menu(commands);
        do
        {
          commands[index].Execute();
        }
        while (!Console.KeyAvailable && model.State);
      }
    }
  }
}
