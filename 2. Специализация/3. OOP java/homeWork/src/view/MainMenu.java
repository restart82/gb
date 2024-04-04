package view;

import view.commands.*;

import java.util.ArrayList;
import java.util.List;

public class MainMenu {
    private List<Command> commandList;
    public MainMenu(ConsoleUI consoleUI) {
        commandList = new ArrayList<>();
        commandList.add(new CreateFamilyTree(consoleUI));
        commandList.add(new AddInFamily(consoleUI));
        commandList.add(new GetMarried(consoleUI));
        commandList.add(new GetChild(consoleUI));
        commandList.add(new AddDeathDate(consoleUI));
        commandList.add(new GetPersonInfo(consoleUI));
        commandList.add(new CreateCustomTree(consoleUI));
        commandList.add(new SaveFamilyTree(consoleUI));
        commandList.add(new DownloadFamilyTree(consoleUI));
        commandList.add(new SortByBirthDate(consoleUI));
        commandList.add(new SortByName(consoleUI));
        commandList.add(new Finish(consoleUI));
    }
    public String menu() {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < commandList.size(); i++) {
            stringBuilder.append(i + 1);
            stringBuilder.append(". ");
            stringBuilder.append(commandList.get(i).getDescription());
            stringBuilder.append("\n");
        }
        return stringBuilder.toString();
    }
    public void execute(int choice) {
        Command command = commandList.get(choice - 1);
        command.execute();
    }
    public int getSize(){
        return commandList.size();
    }
}
