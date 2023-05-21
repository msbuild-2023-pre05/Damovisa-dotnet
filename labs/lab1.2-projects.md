# Lab 1.2 - GitHub Projects

While Issues are great for individual items, planning your work is crucial to working effectively. This means visualising of groups of issues, pull requests, or notes (also known as cards) in an interactive way that makes sense for your team.

Often, teams use external tools (including sticky notes on whiteboards) to track their work, or they'll fall back to simple spreadsheets. [Project Tables and Boards](https://github.com/features/issues) (also known as Projects) are GitHub's way of giving you visibilty over the work you care about.

Built like a spreadsheet, Project Tables give you a live canvas to filter, sort, and group issues and pull requests. They're extremely customizable and you can tailor them to your needs with custom fields.

Project Boards give you a different view over the same data and behave more like kanban or sprint boards with columns for your items. You can customize what appears on each card, which field is used for the column, and apply any number of filters.

In a project, you can save views for sprints, backlogs, teams, or releases. You can rank, group, sort, and filter issues to suit the occasion, and you can choose between tables, boards, and soon a timeline view.

## Exercise 1 - Creating a Project

In this exercise, we'll create a project for your repository and show how you can customize it and add your own custom fields.

1. In your repository, click on the `Projects` tab
2. Click the 🔻 button next to `Link a project` and choose `New project`
3. Now click the green `New project` button.
    <details>
    Projects are actually created at the organization or user level rather than for a specific repository. By creating a project from the repository, we're just shortcutting creating an organization-level project and linking to it from the repository.
    </details>
4. Make sure you select the `Table` template in the `Start from scratch` section and click `Create`
    <details>
    In the future, you may want to start with a different View (board or roadmap), or you may even want to start with a Team backlog or Feature project template.

    You can also choose Organization templates if your organization has set any up!
    </details>
5. Add each of the issues you created earlier in your repository.
    <details>

    1. Click the `+` icon in the grid to add an issue. You can also use `Ctrl-Space`.
    2. Type the `#` character and choose your repository from the dropdown.
    3. Click the bottom option - `Add items from msbuild-2023-pre05/your-repo →`
    4. Click the checkbox at the top of the list to select all issues.
    5. Click the green `Add selected items` button, then close the bulk add panel.

    You can also add issues one by one here. Later, we'll look at automatically adding issues to the project board when they're created.
    </details>

6. Click on an issue title. More details should show in a sidebar.
    <details>
    In this pane, you can add comments and edit the issue itself. 
    
    There are some current limits to what you can do here (you can't convert tasks to issues for example), but most common actions are available.
    </details>

7. Close the issue by clicking the `x` in the top right of the pane.
8. Use `Ctrl-Space` or click the `+` to add a new issue.
9. This time, just type `Add dark mode` and hit Enter.
    <details>
    This creates a "draft issue". Draft issues don't exist in a repository, however they can still be assigned, have a status, and have many other properties of a standard issue.

    Draft issues are useful for tracking cross-cutting work or just making note of a possible issue.

    Draft issues can be converted to real issues by clicking the 🔻 button to the left when you hover over the issue, and clicking `Convert to issue`.

    We'll leave this one as a draft issue for the moment
    </details>

10. Assign the draft issue to yourself.
    <details>
    To set values, you can click the appropriate cell and start typing, or hover over the cell and select the 🔻 dropdown.
    </details>

11. Set the status for all issues to `Todo`.
    <details>
    There are a few ways to do this.

    - You can set the values one by one
    - You can set one value, copy the cell with `Ctrl/Cmd-C`, highlight the rest of the cells, then use `Ctrl/Cmd-V` to paste.
    - You can set one value, then use the blue handle at the bottom right of that cell to "drag" the values down - much like you'd do in Excel!
    </details>

12. Click the header `@your-user-name's untitled project`.
13. Change the name to `@your-user-name: Reading Time` and add a brief description:
    <details>

    Use this (or similar) as the description: `A project to manage work on my personal reading list project`

    You can also add a markdown readme for the project to help newcomers and link to important resources.

    The settings page also gives you the ability to use the project as a template or copy the project.

    On the left, you can manage access to the project as well.
    </details>

14. Click the `...` button at the top right of the page and choose `Workflows`
    <details>
    Workflows give you a way to easily automate common tasks with projects. You're also able to use GitHub Actions to automate projects if you want finer control.
    <details>

15. Select `Auto-add to project` on the left of the page.

16. Click the `✏️ Edit` button on the top right of the page

17. Let's set this workflow up so every new issue for your repository gets added to the project.
    <details>

    1. Ensure the dropdown under `Filters` has your repository set
    2. Change the text for the filter to `is:issue is:open`
    3. Click the green `Save and turn on workflow` button.

    Now, every new issue that gets created in your repository will be automatically added to this project.
    </details>

18. Click the `←` next to `Workflows` at the top left to go back to your table.

> **What have you learned?**
> - How to [create a new project](https://docs.github.com/en/issues/planning-and-tracking-with-projects/creating-projects/creating-a-project))
> - How to [add issues to a project](https://docs.github.com/en/issues/planning-and-tracking-with-projects/managing-items-in-your-project/adding-items-to-your-project)
> - How to edit values for issues from a project
> - How to [auto-add new items to your project](https://docs.github.com/en/issues/planning-and-tracking-with-projects/automating-your-project/adding-items-automatically) with built-in workflows

> **Did you know?**
> - You can create an [Organization-level or User-level project](https://docs.github.com/en/issues/planning-and-tracking-with-projects/creating-projects/creating-a-project)
> - You can use the keyboard a lot in projects. Arrow keys, Enter, copy-and-paste, they all work!

## Exercise 2 - Customizing our views

So far we've only used the defaults in the Table view. In this exercise, we're going to customize our view and add two new ones.

1. Click the `+` button to the right of the last column header.
2. In the dropdown, click the checkbox next to  `Labels`, then click away to close the dropdown.
    <details>
    If you try to set a value for `Labels` for the draft issue, you'll notice that you have to convert to a real issue first. This is because the available labels vary based on repository. Without knowing which repository this issue belongs to, you can't get a list of available labels!
    </details>

3. Set some appropriate labels for the issues.
4. Let's add a custom column for an Estimate.
    <details>
    
    1. Click the `+` button to the right of the `Labels` column and choose `+ New field`.
    2. Type `Estimate` as the field name, and choose `Number` as the field type.
    3. Click `Save`.
    </details>

5. Set some values for the `Estimate` column in your table.
    <details>

    Unlike the other fields in our table, this `Estimate` field is _not_ a property of the issue itself. Rather, it's a value for that issue _in this project_.

    An issue can belong to multiple projects and have different values for custom project fields - even if they have the same name.
    </details>

6. Let's add another custom column for Priority.
    <details>

    1. Again, click the `+` button to the right of the last column to add a `New field`
    2. This time, use `Priority` for the field name and `Single select` for the field type.
    3. Add three options:
      - 🏖️ Low
      - ⚠️ Medium
      - 🔥 High

    You can search for and add emoji easily by typing `:`. Feel free to use your own selection instead!

    You can further customize these options by clicking the ✏️ icon next to each option to choose colors and add descriptions.
    </details>

7. Set values for the `Priority` column for all items in your table.

8. Sort your table by estimate by clicking the `...` in the header of the `Estimate` column and choosing `Sort descending`.

9. Use keyboard shortcuts to group by the `Priority` field.
    <details>

    1. Press `Ctrl/Cmd-K` on your keyboard (this is called the command palette)
    2. Select `Group by...` then choose `Priority`

    You can also do this entirely with they keyboard by typing and using the `Tab` and `Enter` keys to select. Try it out!
    </details>

10. Remove the grouping by clicking on the `...` in the `Priority` header and choosing `Grouped by field`.

11. Remove the sorting by clicking the `...` in the `Estimate` header and choosing `Sorted descending`

12. Use the command palette (`Ctrl/Cmd-K`) to filter items to only those with an `Estimate` greater than 5 (or an appropriate value for you)
    <details>
    
    1. Press `Ctrl/Cmd-K` and look for the `Filter by` command
    2. Choose `Filter by Estimate`
    3. Your cursor should appear in the filter section at the top of the table to the right of `estimate:`.
    4. Type `>5` (or an appropriate value) and press `Enter`.

    The table should now be filtered appropriately.
    </details>

13. Clear the filter by deleting the contents of the filter textbox.

14. Create a new column to manage our iterations called `Sprint`
    <details>

    1. Click the `+` button to the right of the last column in the header and choose `New field`
    2. Name the field `Sprint`
    3. Set the field type as `Iteration`
    4. Leave the Options as their defaults and click `Save and create`

    This field type does a little more than the others. It creates a set of iterations that you can manage and assign work to as the project continues.

    These iterations are editable as we'll soon see.
    </details>

15. Fill in values for the `Iteration` field in your table. Try to spread the work out a little.

16. Click the `...` button at the top right of the page and choose `Settings`
    <details>
    This takes us to the settings page we saw before.

    On the left, you can see all our custom fields, and you can click each one to edit.
    </details>
    
17. Click the `Iteration` Custom field and make some changes (we won't save them)
    <details>

    1. Click the dates for `Sprint 2`
    2. Pick new dates one week ahead of the current values and click `Apply`
    3. Notice how a break is inserted between `Sprint 1` and `Sprint 2`, and `Sprint 3` is pushed out a week.
    4. You can also insert a break by clicking the `Insert break` button that appears when you hover over a line between iterations.
    5. Click the `+ Add iteration` button at the top to add another sprint in line with the current duration.
    6. Click the `More options 🔻` button to add a new sprint with custom dates and duration.
    7. When you're finished experimenting, click the `Reset` button to cancel your changes.
    </details>

18. Click the `←` button at the top right of the page next to `Settings` to go back to your table.

19. Click the tab at the top that says `View 1` to change the name of this view to `Backlog`.

20. Click the `Save` button to the right of the filter textbox to save the changes. Alternatively you can click the 🔻 dropdown in the tab and choose `Save`.

> **What have you learned?**
> - How to [customize a table layout](https://docs.github.com/en/issues/planning-and-tracking-with-projects/customizing-views-in-your-project/customizing-the-table-layout)
> - How to [use custom fields in a project](https://docs.github.com/en/issues/planning-and-tracking-with-projects/understanding-fields)

> **Did you know?**
> - [Date fields](https://docs.github.com/en/issues/planning-and-tracking-with-projects/understanding-fields/about-date-fields) will be useful in the roadmap view!


## Exercise 3 - Creating a sprint board

In this exercise, we're going to create another view layout called the "Board layout" to create a sprint board.

1. Click the `+ New View` button to the right of the `Backlog` tab and choose `Board` as the layout.
    <details>
    You'll notice that all your issues are visible on this board as cards - you don't have to add them again.

    All views in a project share the same issues, draft issues, and pull requests, however you can customize what you see with the use of filters.
    </details>

2. Let's change the appearance of the cards to include `Estimate` and `Priority`
    <details>

    1. Click the 🔻 button next to the `View 2` tab title and choose `Fields`
    2. Check the checkboxes next to `Estimate` and `Priority`.
    3. If you like, add any other fields you'd like.
    4. Click away to close the dropdown.
    </details>

3. Let's add a sum of the `Estimate` field for each column.
    <details>

    1. Click the 🔻 button next to the `View 2` tab title and choose `Field sum`
    2. Check the checkbox next to `Estimate` then click away.

    You'll see the sum of the `Estimate` field at the top of each column.

    You can do this with any custom field with the number field type.
    </details>

4. By default, the columns used for this view is based on the `Status` field. Let's change it to `Sprint` temporarily and make sure we have the right issues in sprint 1.
    <details>
    
    1. Click the 🔻 button next to the `View 2` tab title and choose `Column by`
    2. Choose `Sprint` and click away to see the new board.
    3. Drag these three issues into `Sprint 1`:
      - `💻 Create dev container`
      - `🐛 Fix book cover images` 
      - `Add book ratings`

    You can choose any custom field with the single dropdown or iteration field type for your columns.
    </details>

5. Change the `Column by` back to `Status`
    <details>

    1. Click the 🔻 button next to the `View 2` tab title and choose `Column by`
    2. Choose `Status` and click away.
    </details>

6. Finally, let's filter the issues to only show the current sprint.
    <details>

    1. Press `Ctrl/Cmd-K` to open the command palette
    2. Find `Filter by Sprint`
    3. In the filter field, select (or type) `@current`.

    Note that you can choose a specific sprint, as well as `@previous` or `@next` here as well.
    </details>

7. Let's add a `Blocked` status to our board.
    <details>

    1. Click the large `+` button to the right of the `Done` column.
    2. Choose `+ New Column`
    3. Name the status `Blocked` and color it red.
    4. Click `Save`
    5. Click and drag the header of the new `Blocked` column to place it between `In Progress` and `Done`

    Creating a new column in this way will add a new value to the column field. If it's a single dropdown field, that custom field will have a new value. Similarly, if you're using an iteration field type, a new iteration will be created.
    </details>

8. Finally, let's give the view a name and save our changes.
    <details>

    1. Click the `View 2` title in the tab and change the name to `Sprint Board`
    2. Click the 🔻 dropdown next to the tab title and choose `Save`. You can also use the `Save` button to the right of the filter text box.
    </details>

> **What have you learned?**
> - How to [customize a board layout](https://docs.github.com/en/issues/planning-and-tracking-with-projects/customizing-views-in-your-project/customizing-the-board-layout)


## Exercise 4 - Visualizing a roadmap

The final layout type is the Roadmap view. In this exercise, we'll create a product Roadmap view for our project.

1. Click the `+ New View` link to the right of the `Sprint Board` tab and choose `Roadmap` as the layout type.

2. You'll be given some information about what's required for a Roadmap view.
    <details>
    In short, you need at least one custom date or iteration type field. The start and end dates of an issue in the roadmap view need to be tied to some values.
    </details>

3. Click the `Date fields` link at the top right of the roadmap view to open the field selection dropdown (if it's not already open)

4. Choose `Sprint start` as the start date, and `Sprint end` as the end date.

5. Try dragging some of the bars in the roadmap view to new places. You'll note they will snap to sprint dates. Ensure you move the book ratings, dev container, and cover images issues back to the dates for sprint 1.

    <details>
    While seeing the sprint dates for each of the issues has _some_ use, this view is far more useful if we have custom date fields for start and finish dates.
    </details>

6. Let's add new fields to track target start and finish dates for our issues.
    <details>

    1. Click the `Date fields` link again and choose `+ New field`
    2. Create a field called `Estimated Start` with the `Date` field type.
    3. Click `Date fields` again and choose `Estimated Start` for the Start date field.
    4. Repeat the process to add `Estimated End` and set it to the Target date field.
    </details>

7. Lets set some values for our estimated start and end dates
    <details>

    1. Click in the main area of the roadmap view to set a Start date
    2. Drag the right side of the bar to move the Target date.
    3. Add some more bars to the roadmap view for some of the other issues
    4. Click on one of the bars to open the issue flyout pane. You can see the custom fields on the right and the `Estimated Start` and `Estimated End` fields will be set according to the start and finish of the bar in the roadmap view.
    </details>

8. Let's add some sprint markers.
    <details>
    
    1. Click the `Markers` link at the top right of the roadmap view.
    2. Check the checkbox next to `Sprint`
    
    You'll see the sprint dates are marked above the dates in the roadmap view.
    </details>

9. Let's name and save this view.
    <details>

    1. Click the `View 3` title in the tab and change the name to `Roadmap`
    2. Click the 🔻 dropdown next to the tab title and choose `Save`. You can also use the `Save` button to the right of the filter text box.

    You can also filter, sort, and zoom this view to customize your roadmap view further.
    </details>

> **What have you learned?**
> - How to [customize a roadmap layout](https://docs.github.com/en/issues/planning-and-tracking-with-projects/customizing-views-in-your-project/customizing-the-roadmap-layout)

> **Did you know?**
> - You can also group by fields in this view, and even add [field sums for the grouped fields](https://docs.github.com/en/issues/planning-and-tracking-with-projects/customizing-views-in-your-project/customizing-the-roadmap-layout#showing-the-sum-of-a-number-field)!


## Next Steps

- Move on to the next lab! :next_track_button: [Lab 2.1 - The Web-Based Editor](./lab2.1-web-editor.md)

## Resources
- [Planning and Tracking with Projects](https://docs.github.com/en/issues/planning-and-tracking-with-projects)
