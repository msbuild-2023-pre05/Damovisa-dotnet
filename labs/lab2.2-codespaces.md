# Lab 2 - Working in GitHub Codespaces

Blazing fast cloud developer environments!

One of the biggest challenges organizations face is onboarding new developers to projects. There are libraries to install, services to configure, version issues, obscure error messages... It can literally take days to get everything running before a developer is able to write their first line of code. [GitHub Codespaces](https://github.com/features/codespaces) is built to streamline this entire process. You can configure a container for development which your devs can access with just a couple of clicks from basically anywhere in the world. The container runs in the cloud, has everything already setup, and ready to go. Instead of days your developers can start writing code in seconds.

Let's explore how to create and configure a Codespace for a .NET 7 web app. (Don't worry; you don't need to be proficient in .NET to complete this workshop!)

## Exercise 1 - Provisioning and managing your Codespace

GitHub provides a [default container](https://docs.github.com/codespaces/setting-up-your-project-for-codespaces/adding-a-dev-container-configuration/introduction-to-dev-containers#using-the-default-dev-container-configuration) for all repositories. This container is based on a Linux image, and contains many popular runtimes including Node.js, Python, PHP and .NET. In many scenarios, this default container might be all you need. You also have the ability to configure a custom container for the repository, as you'll see later in this lab. For now, let's explore how to use the default container.

1. If not already open, open your repository in your browser.
1. From the `Code` tab (suggest to open a new browser tab) in your repo, access the green `<> Code` dropdown button and from the `Codespaces` tab click `Create codespace on main`.
1. Allow the Codespace to load; it should take less than 30 seconds because we are using the default image.
1. Examine the user experience - it's running Visual Studio Code in your browser! In the `Terminal` window in the middle of the screen you'll see messages as your codespace finishes spinning up.
1. In the terminal window, run: `devcontainer-info` to see the information about the container that is running your codespace. If you are curious, you can click on the link to see what the default dev container image contains.

    <details>

    - You are using a default, linux-based container. We can (and will) customize the Dev Container later in the workshop.
    - If you aren't seeing the terminal window, open the command palette by using <kbd>Ctl</kbd> + <kbd>`</kbd>
    </details>

1. In the terminal window, run: `free -m` to see how much memory our codespace has (4gb).
1. Let's upgrade our codespace to a larger instance. Upgrading your Codespace to a bigger machine doesn't require submitting paperwork to procurement, but it will require your codespace to restart. Your organization can specify which size(s) are available to you.

    <details>

   1. Open a new browser tab and navigate to [https://github.com/codespaces/](https://github.com/codespaces/). You will see a list of your codespaces including the current `Active` codespace.
   1. Select the `...` ellipses button next to that codespace and select `Change machine type`. Select the **4-core machine** and select `Update codespace`.
   1. Again, select on the `...` button next to the Codespace but this time select `Stop codespace`.
   1. Close this tab and back to the original browser tab containing your Codespace and select `Restart codespace`.
   1. Once the codespace is back online, again run the `free -m` command from the terminal window and notice that the memory has increased to 8gb.<br/>

   > **Note** You can also use the Command Palette (<kbd>F1</kbd>) and type `Codespaces: Change Machine Type` to change the machine type instead of using the UI.
   </details>

1. You are now ready to go the next exercise!

> **What have you learned?**
> 
> - How to [create a Codespace](https://docs.github.com/codespaces/developing-in-codespaces/creating-a-codespace?tool=webui) ready to start working in no time without any additional setup
> - How to [change the machine type](https://docs.github.com/codespaces/customizing-your-codespace/changing-the-machine-type-for-your-codespace) for your Codespace

> **Did you know?**
> 
> - You can [synchronize your settings](https://code.visualstudio.com/docs/editor/settings-sync) to tailor your experience to your needs and that will follow from codespace to codespace and the desktop version of VS Code as well. This can be turned on by clicking on the `settings` cog icon in the lower left-hand corner clicking and `Turn on Settings Sync...`
> - If you prefer to use VSCode Desktop to edit code, but still run the compute on the cloud, you can open the code on your machine by selecting the option `Open in VS Code Desktop` available on the menu (top left of the screen the 3 horizontal lines icon). For this lab, stay in the browser :smile:.
> - You can open a codespace directly from the command line by running `gh codespace create` with the [GitHub CLI](https://cli.github.com) tool? The same command line even allows you to SSH into your codespace.

## Exercise 2 - Developing in your Codespace

When connecting to your Codespace from a browser you are using a version of Visual Studio Code which is nearly identical to the version you'd run on your desktop. You can perform the normal operations you would on a day-to-day basis, including using extensions, executing your application and running the debugger. Let's see how you can run your site.

1. If you happened to leave your codespace, re-open it.
    <details>

    1. On **your** repo's home page, click the green `<> Code` button.
    1. Select your existing codespace from the list.
    1. Wait for your codespace to start. This could take a moment, but should be faster than the first time you created it.
    </details>
1. Examine the terminal prompt. You should be able to see that the current working directory is `/workspaces/your-repo-name`.
1. Run a `ll` or `ls` command to list the files in the current working directory (the root of the repo).
1. In the Terminal prompt, type `cd src/` and press return.
1. Next, type `dotnet build` and press return. This should successfully build the application's solution.
1. Next, type `cd ReadingTime6.Web/` and press return. This will enter the web project's directory.
1. Now, type `dotnet run` and press return. This will run the web application.
1. When the notification pops up in the lower right-hand corner and says `Open in browser` : select it. You may need to allow pop-up in your browser to do so.
    <details>

    It should look like this:
    
    ![Screenshot of the application running in a web browser](https://user-images.githubusercontent.com/19912012/200029613-004e8931-2b6e-45b2-adba-5875e373b5d7.png)
    </details>
1. If you missed it, navigate to the `Ports` tab (to the right of `Terminal`), hover over the entry in the `local address` column, and select the `globe icon`.
1. You should see your website!
    <details>

    If you were debugging locally, you would navigate to `localhost:5000` to see the site. In this case, you are running the site in a Codespace and the port is being forwarded to a URL that by default, is only accessible by you.

    If you see a `502`, `503`, or `504` error, wait a few seconds and refresh the page. The site is still starting up! :sleeping:
    </details>
1. Select on the `View Inventory` button on the website.
1. You should see a list of books - but oh no, there's a bug 🐛 with the images! We will have to fix that.
1. Now close the browser tab of the site.
1. Back in your Codespace, place your cursor in the `Terminal` window (you may have to re-select on `Terminal` if you selected on `Ports` before to navigate to your website).
1. Press <kbd>Ctl</kbd> + <kbd>C</kbd> to stop the `dotnet` process.

> **What have you learned?**
> - How to run commands and [develop in your Codespace](https://docs.github.com/codespaces/developing-in-codespaces/developing-in-a-codespace)
> - How [forwarding ports](https://docs.github.com/codespaces/developing-in-codespaces/forwarding-ports-in-your-codespace) in your Codespace works

> **Did you know?**
> - By default, the exposed ports are only available to you, but you can make them available to your entire org or the world in general by making it public. See more on [forwarding ports in your codespace](https://docs.github.com/codespaces/developing-in-codespaces/forwarding-ports-in-your-codespace)
> - You can connect your codespaces to access resources on private networks. See more on [connecting to a private network](https://docs.github.com/codespaces/developing-in-codespaces/connecting-to-a-private-network)
> - You can preview your application inside codespaces with [Codespaces Simple Browser](https://github.blog/changelog/2022-10-20-introducing-the-codespaces-simple-browser/) without the need to open a new browser tab?

## Exercise 3 - Add a dev container

One thing that's really great is the [default dev container](https://github.com/devcontainers/images/blob/main/src/universal/.devcontainer/Dockerfile) has `.NET 7`, `node`, `python`, `mvn`, and more. But what if you need other tools? Or in our case, we want don't want to have each developer install the `C# VS Code Extension` for debugging, we want to have everything pre-configured from the start!

Let's create our own dev container! The [dev container is configured](https://docs.github.com/codespaces/setting-up-your-project-for-codespaces/adding-a-dev-container-configuration/introduction-to-dev-containers) by creating the Docker files Codespaces will use to create and configure the container, and providing any customizations in the `devcontainer.json` file. Customizations provided in `devcontainer.json` can include ports to open, commands to run, and extension to install in Visual Studio Code (either running locally on the desktop or in the browser). This configuration becomes part of the repository. All developers who wish to contribute can then create a new instance of the container based on the configuration you provided.

1. First, let's take a look at the list of issues in the repository. Run this in the terminal window: `gh issue list`
1. We should see a `#1  :computer: Create dev container` issue. We can further examine the issue by running `gh issue view 1`
1. Let's now create the dev container. Access the Command Palette (<kbd>F1</kbd>), then start typing `dev container`.
1. Select `Codespaces: Add Development Container Configuration Files...` .
1. Select `Create a new configuration...`
1. Type `C#` and select the `C# (.NET)` option.
1. Pick `7.0-bullseye`.
1. Type / Select `Azure CLI` and `GitHub CLI` from the additional features to install and click `OK`.
1. Pick `Keep Defaults`.
1. **BEFORE rebuilding the container**, let's make one customization to the dev container configuration to add in the `C# extension` and `GitHub Copilot`.
    <details>

    > **NOTE**: You can find an extensions ID by opening the `Extensions` pane, right-clicking on the extension and selecting `Copy Extension ID`
    </details>
1. The `.devcontainer/devcontainer.json` file should have opened. If not, open it from the `Explorer` pane.
1. Examine the file - note that this is where the image and node version we selected are stored.
1. Add a new line after `line 6` (`"image": ...`).
1. Paste in the following JSON block, ensuring `"customizations"` is at the same indentation as `"features"`:

    ```json
        // Configure tool-specific properties.
        "customizations": {
            // Configure properties specific to VS Code.
            "vscode": {	
                // Add the IDs of extensions you want installed when the container is created.
                "extensions": [
                    "ms-dotnettools.csharp",
                    "GitHub.copilot"
                ]
            }
        },
    ```

    > **NOTE** The entire **devcontainer.json** file is in the details section:

    <details>

    The entire file should look like:

    ```json
    {
        "name": "C# (.NET)",
        // Or use a Dockerfile or Docker Compose file. More info: https://containers.dev/guide/dockerfile
        "image": "mcr.microsoft.com/devcontainers/dotnet:0-7.0-bullseye",
        // Configure tool-specific properties.
        "customizations": {
            // Configure properties specific to VS Code.
            "vscode": {	
                // Add the IDs of extensions you want installed when the container is created.
                "extensions": [
                    "ms-dotnettools.csharp",
                    "GitHub.copilot"
                ]
            }
        },
        "features": {
            "ghcr.io/devcontainers/features/azure-cli:1": {},
            "ghcr.io/devcontainers/features/github-cli:1": {}
        }

        // Features to add to the dev container. More info: https://containers.dev/features.
        // "features": {},

        // Use 'forwardPorts' to make a list of ports inside the container available locally.
        // "forwardPorts": [5000, 5001],
        // "portsAttributes": {
        //		"5001": {
        //			"protocol": "https"
        //		}
        // }

        // Use 'postCreateCommand' to run commands after the container is created.
        // "postCreateCommand": "dotnet restore",

        // Configure tool-specific properties.
        // "customizations": {},

        // Uncomment to connect as root instead. More info: https://aka.ms/dev-containers-non-root.
        // "remoteUser": "root"
    }
    ```
    </details>

1. Rebuild the container - don't worry any file edits will persist. The only thing that is being updated is the container the environment is running in.
    - If you see a notification popup with `Rebuild Now`, select `Rebuild Now.

      ![Screenshot of rebuild now popup](https://user-images.githubusercontent.com/19912012/200040026-8d3a4eb8-b502-4a84-a36d-d650d2279c9d.png)
      
    - Or, open the Command Palette (<kbd>F1</kbd>), type `rebuild` and select `Codespaces: Rebuild Container`. Confirm that you want to rebuild your container.
1. Wait for the container to rebuild. This will take a few minutes. You're doing great! This is a great time to stretch 🙆 or grab a beverage 🥤. 
1. If you're interested, you can select `View logs` to watch the container build.
1. Once the codespace finishes rebuilding, let's see if the `C# extension` installed. Click the `Extensions` pane and if you see `C#`, you are good. If this is somehow missing, search for `C#` in the search bar and install it.
1. Commit the file changes using a commit message like: `adding dev container - fixes #1`

    1. Select the `Source Control` pane ![Screenshot of the source control icon](https://user-images.githubusercontent.com/19912012/200052933-8c2cb0d6-5474-49fd-8f4a-41d9a9509031.png).
    1. Notice the `devcontainer.json` file is in the `Changes` section.
    1. Stage the changes by selecting the `+` button next to each changed file or the `Changes` heading.
    1. Add a commit message - something like: `adding dev container - fixes #1`
    1. Select the `✔️ Commit` button.
    1. Select the `Sync Changes 1 ^` button to push your change (or run `git push` from the terminal window).
    1. A warning may appear - you can click `OK, Don't Show Again`.

    > **Note** If you use a keyword like `fixes #1` in your commit message, it will automatically close issue #1, which is our 'Create dev container' issue. See [link](https://docs.github.com/get-started/writing-on-github/working-with-advanced-formatting/using-keywords-in-issues-and-pull-requests) for more details on what other keywords you can use.

1. We shouldn't see our issue appear anymore if we run: `gh issue list`
1. To double check that the issue was closed, run this in the terminal window: `gh issue view 1`

    - We should see that the issue shows a purple `closed` status.
    - We can also see the description and assignees of the issue.
    - Alternatively, to see the issue in the web, we can click on the `Codespaces` button ![image](https://user-images.githubusercontent.com/19912012/200068097-a8bafd12-09aa-4181-82f9-0161aaef3980.png) in the lower left-hand corner, `Go to Repository`, click `Issues`, and see if we see `2 open` and `1 closed` - you can click on the `1 closed` link to see the issue.

> **What have you learned?**
> 
> - You can customize the developer experience by having a standardized development environment by creating a [devcontainer.json](../.devcontainer/devcontainer.json) file. You can personalize to your liking using [Dotfiles](https://docs.github.com/codespaces/customizing-your-codespace/personalizing-github-codespaces-for-your-account) and many more things. For more information read [introduction to dev container](https://docs.github.com/codespaces/setting-up-your-project-for-codespaces/introduction-to-dev-containers)
> - How to [work with source control](https://docs.github.com/codespaces/developing-in-codespaces/using-source-control-in-your-codespace) in your Codespace and commit changes
> How to use some basic [GitHub CLI command line](https://docs.github.com/github-cli/github-cli/about-github-cli) commands

> **Did you know?**
> 
> - The GitHub CLI commands know what repository you are in, so you don't have to specify the repository name. 
> - Also, since you are running in Codespaces, it knows who YOU are. If you create an issue using the GitHub CLI command, it will show up as created by you without having to authenticate again.

## Exercise 4 - Debugging in your Codespace

With our custom image built, let's turn our attention to the bug. Our configuration is now part of the repository, meaning anyone who wishes to contribute to our project will be able to use the same image! No more configuration headaches! Instead we can focus on the other headache - bugs 🐛.

As we saw before, our images aren't loading. Let's figure out why. We're going to follow a streamlined DevOps process by first finding the issue which relates to the bug, creating a fix, and pushing it to the main branch.

> **NOTE**
> 
> Normally you would [create a pull request](https://docs.github.com/get-started/quickstart/github-flow#create-a-pull-request) as part of the flow, but for our purposes we will push to main.

1. In the browser window with your Codespace, run the following command in the terminal window to list all issues: `gh issue list`
    > **Note** Instead of using the CLI, you can also click on the `GitHub` octocat pane icon and expand the `My Issues` dropdown to see the issues assigned to you.
1. You should see a `#2  :bug: Fix book cover images` issue. You can further examine the issue by running `gh issue view 2`
1. Next, let's run some unit tests to see if this helps us in debugging our issue. In the Terminal prompt, navigate to your unit tests folder.
    - You should be able to enter `cd src/ReadingTime6.Web.Tests.Unit/` and press return.
    - If you are stuck, this command should work also:

      `cd $CODESPACE_VSCODE_FOLDER/src/ReadingTime6.Web.Tests.Unit/`
1. Enter `dotnet test` and press return.
1. Okay, you should see **12** tests 🧪 pass :white_check_mark: and 1 test 🧪 failed :x:. Ohh, from the error message, we might have discovered our bug 🐛.
    > **Note** A tip is that you can "<kbd>⌘</kbd> - click" on macOS "<kbd>ctl</kbd> - click" on Windows on the `/workspaces/your-repository/src/ReadingTime6.Web.Tests.Unit/BookTests.cs:line 29` in the Terminal window to open the file in the editor, along with the line number where the test failed. You can then right click the `Book` on `new Book` and select `Go to Definition` to see the code where this is being defined in `Books.cs:line 25`.
1. Let's set a breakpoint in the code to see if we can further diagnose the issue.
    1. In the `Explorer` pane ![Screenshot of explorer pane](https://user-images.githubusercontent.com/19912012/200037653-48e8cb42-7967-488d-831f-1046fd439c76.png), open the `src/ReadingTime6.Web/Controllers/BookController.cs` file.
    1. Place your cursor on `line 18`, which is the line that reads `return View(bookService.Books());`.
    1. Click the `red circle` icon to the left of the line number (in the "gutter") to add a breakpoint, like so: ![Screenshot of debug break circle](https://user-images.githubusercontent.com/19912012/200049139-d7161356-aa88-486d-b69d-0b1010254293.png)
1. Start debugging!
    1. Click the `Run and Debug` ![Screenshot of icon for Run and Debug pane](https://user-images.githubusercontent.com/19912012/200047101-e4d2e6ef-6a01-4c7a-9a7c-93f814e0a1ef.png) pane
    1. Click the green `play` button ![Screenshot of play button](https://user-images.githubusercontent.com/19912012/200047608-672a2143-39fc-4da5-97c5-bb07555afe97.png) to start debugging.
1. Open the site (either by clicking on the `open in browser` notification in the lower right, or by navigating to the Ports tab and clicking the `globe icon` under the `local address` column).
1. Click on the `View Inventory` button
1. You should notice that your page loading is spinning and your Codespaces tab now has a red dot on it, indicating that it has hit a breakpoint. Re-open the Codespaces tab to take a look.
    <details>
    It should look like this:
      ![Screenshot of Codespace with breakpoint stopping code](https://user-images.githubusercontent.com/19912012/200049484-50039c0f-fe8a-431f-af10-ec291d454700.png)
    </details>
1. Hover over the `bookserver` object, and inspect one of the items in the list. See anything off? Note how the `Cover` property is using `.png` instead of `.jpg`:

      ![Screenshot of quick peek of bookService object](https://user-images.githubusercontent.com/19912012/200050402-edfa8736-e872-47ca-ba96-1fc052319eb3.png)
1. Find where the `Cover` property is being set to see if there is something erroneously setting the images to `.png` instead of `.jpg`.
    1. Open the `Search` pane ![Screenshot of search pane icon](https://user-images.githubusercontent.com/19912012/200051135-b377f4a5-48b6-4696-a710-b0d076448ad0.png)
    1. Search for: `".png"` (with the quotes)
    1. Click on the result in `Book.cs` to open the file
    1. Remove the `.Replace(".jpg",".png")` function from the line
    1. The line should now read: `Cover = cover;`
1. After making the code fix, in the debugging toolbar, click the green `restart` button to restart debugging (<kbd>⇧</kbd> + <kbd>⌘</kbd> + <kbd>F5</kbd>) in macOS or <kbd>Ctl</kbd> + <kbd> + <kbd>Shift</kbd> + <kbd>F5</kbd>` in windows).
    <details>

    This button: ![Screenshot of restart button](https://user-images.githubusercontent.com/19912012/200098170-86b980dd-25fd-431f-b627-d3654e5f1614.png)
    </details>
1. Re-open the site and select the `View Inventory` button again.
1. Your breakpoint should be hit again. Navigate back to the codespaces browser tab to continue debugging.
1. If you inspect the list items and their properties again, you should see that the cover image looks better now with a `.jpg` file extension.
1. Click the `|>` continue button (or <kdb>F5</kbd>) in the debugging toolbar to tell the debugger to continue.
    <details>

    This button: ![Screenshot of play button](https://user-images.githubusercontent.com/19912012/200098220-f92cb96e-3d97-4b93-9924-748c9e32006e.png)
    </details>
1. Navigate back to the tab with the site open - nice, images load! 🎉
1. Close the web page tab.
1. Back in your codespace, stop debugging by clicking the `red square` (<kbd>⇧</kbd> + <kbd>F5</kbd> in macOS or  + <kbd>Shift</kbd> + <kbd>F5</kbd> in Windows)
1. In the terminal window, run `dotnet test` again in the `/src/ReadingTime6.Web.Tests.Unit/` folder. You might have to push <kbd>Ctl</kbd> + <kbd>C</kbd> to exit the debugging terminal. All 13 tests 🧪 should pass now :white_check_mark:! 🎉
1. In the `Source Control` pane, commit your changes - use something like `fixing images - closes #2` as the commit message
1. Push your change by clicking on the `Sync Changes 1 ^` button
1. Verify that our issue is closed by running `gh issue list` or `gh issue view 2`
1. At this point, feel free to play around, run the unit tests, and even make "basic" code changes (don't break it you'll use it later.) When ready continue.
1. Stop the codespace for now.
    <details>

    1. Click on the `Codespaces` button ![image](https://user-images.githubusercontent.com/19912012/200068097-a8bafd12-09aa-4181-82f9-0161aaef3980.png) in the lower left-hand corner
    1. Click `Stop Current Codespace`
    </details>

> **What have you learned?**
> 
> - How to [debug using VS Code](https://code.visualstudio.com/Docs/editor/debugging#_debug-actions) in your Codespace

## Next Steps

- Move on to the next lab! :next_track_button: [Lab 3 - Copilot](./lab3.md)

## Resources

- [About Codespaces - GitHub Docs](https://docs.github.com/codespaces/overview)
- [Quickstart for GitHub Codespaces](https://docs.github.com/codespaces/getting-started/quickstart)
- [Deep Dive into Codespaces](https://docs.github.com/codespaces/getting-started/deep-dive)
- [Managing encrypted secrets for your codespaces](https://docs.github.com/codespaces/managing-your-codespaces/managing-encrypted-secrets-for-your-codespaces)
- [Codespaces: Configure Dev Container Configuration Features](https://docs.microsoft.com-us/visualstudio/online/reference/configuring#configure-dev-container-configuration-features)
- [Codespaces: Rebuild Container](https://docs.microsoft.com-us/visualstudio/online/reference/configuring#rebuild-container)
