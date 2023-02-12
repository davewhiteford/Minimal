﻿using Actions;
using Actions.Commands;
using Model.Utils;

namespace Minimal.Cli.Services;

public class Populator
{
    public Populator(CommandFactory commandFactory, ModelDataContext dataContext)
    {
        CommandFactory = commandFactory;
        DataContext = dataContext;
    }

    public CommandFactory CommandFactory { get; set; }

    public ModelDataContext DataContext { get; set; }

    public async Task Go()
    {
        var command = CommandFactory.Create<ArtistCommandCreate>();
        command.Props.Name = "Dave";
        command.Props.DateOfBirth = new DateOnly(1980, 11, 20);
        await command.Execute();
    }
}