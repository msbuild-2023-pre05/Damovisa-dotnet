# Codespaces Lab 3 - Reusable Workflows

In this lab, we will be using a [Reusable Workflow ](https://docs.github.com/en/actions/using-workflows/reusing-workflows)to deploy to production. Reusable workflows allow for workflow reuse, whether to share a workflow across multiple repositories or to implement a standard across the enterprise.

## Exercise 1 - Adding in the Reusable Workflow

First, lets create an `environment` manually - it will create one for us automatically if we add it to your YML, but we want to add an approver first.

1. Go to `Settings` and then `Environments` in your repository.
2. Go to the `Environments` (in left-hand menu bar).
3. Click `New Environment`
4. Add `Production`.
5. Check the box for `Required reviewers` and search for your name in the list to add yourself as an approver.
6. Click `Save protection rules`.
7. Add in this YML to your `.github/workflows/readingtime6.yml` workflow file:
    ```yml
      deploy-production:
        needs: deploy-staging
        uses: octocloudlabs/common-workflows/.github/workflows/deploy_dotnet_webapp.yml@v1
        with:
          client-id: 'REPLACE-ME'
          tenant-id: 'REPLACE-ME'
          subscription-id: 'REPLACE-ME'
          environment: Production
    
    ```
8. Replace the `REPLACE-ME` values with the following with the values in your `🎉 Data for your labs` issue ([issues](../../../issues/3)).
9. Commit the changes.
10. Navigate to your workflow run that should have been queued. You should see 3 jobs now - `build`, `deploy-staging`, and `deploy-production`.
11. After the `deploy-staging` job finishes, an `approval` should appear. Approve it! :white_check_mark:
12. You should see the workflow run and deploy to production. :tada:
13. Navigate to the [repository where the reusable workflow](https://github.com/octocloudlabs/common-workflows/blob/main/.github/workflows/deploy_dotnet_webapp.yml) is stored and compare/contrast it to the staging job where we put the steps inline. :eyes:
14. It's a good idea to add `inputs` for any value that *might* change between the environments - note that there are a lot of inputs that have defaults so they *can be* overridden if desired. When we call the workflow, the only inputs we really needed to pass was `client-id`, `tenant-id`, `subscription-id`, and `environment`. :bulb:

> **What have you learned?**
> - Using [reusable workflows](https://docs.github.com/en/actions/using-workflows/reusing-workflows)
> What have you learned?
> - Using [Environments for deployment](https://docs.github.com/en/actions/deployment/targeting-different-environments/using-environments-for-deployment)
> - Configuring [reviewing deployments](https://docs.github.com/en/actions/managing-workflow-runs/reviewing-deployments)

## Next Steps

- [Lab 4 - Optional - Prebuilds](./lab4-optional-prebuilds.md)

## Resources

- [Reusing Workflows](https://docs.github.com/en/actions/using-workflows/reusing-workflows)
