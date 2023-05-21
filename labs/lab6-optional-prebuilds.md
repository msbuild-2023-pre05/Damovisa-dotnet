# Universe 2022 Workshop
**Build a web app with Codespaces and deploy it to Microsoft Azure with GitHub Actions**

## Lab 4 - Configuring prebuilds

Prebuilds provide a way for you to preconfigure a codespace configuration so that users gain faster access when provisioning a new codespace environment. This is especially useful for large or complex repositories.  As an example, the largest source code base for github.com takes approximately 29Gb on the filesystem when fully populated including source code, dependencies, etc. Using a prebuilt codespace, a GitHub engineer can spin up a new environment and be working on the code within seconds!!!

The real value of prebuilts is derived from large, complex repos.  So they won't add much value for the `spring-petclinic` repo for this workshop. But they are easy enough to configure that you might as well give it a shot!

### Exercise 1 - Configuring a prebuild for the workshop repo

1. Open the browser on your repository and click on `settings` on the top bar.
1. Click on `Codespaces` on the left menu.
1. Click on `Set up prebuild button`
1. Select the `main` branch 
1. Select an appropriate prebuild trigger (you can always change it later, but for now let's use `On configuration change`)
1. Click on `Reduce prebuild available to only specific regions` and select the appropriate region(s) for your development teams. 
1. Click on the `Create` button.
1. Once the `See output` button is available click on it to be familiar with the prebuild process.
1. This will take a while - if you'd like to wait and test the prebuild, feel free!  But you **don't need** to wait for it to finish.
1. To verify, again click on the `Settings` and `Codespaces` links in your repo. You can review all available prebuild configurations for your repo, including whether they are ready or still building.

## Resources

- GitHub Docs: [About GitHub Codespaces prebuilds](https://docs.github.com/en/codespaces/prebuilding-your-codespaces/about-github-codespaces-prebuilds)
