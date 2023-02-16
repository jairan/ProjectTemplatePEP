using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;
using EnvDTE;

namespace ProjectTemplatePepWizard
{
  public class WizardImplementation : IWizard
  {
    private UserInputForm inputForm;
    public void BeforeOpeningFile(ProjectItem projectItem)
    {
    }

    public void ProjectFinishedGenerating(Project project)
    {
    }

    public void ProjectItemFinishedGenerating(ProjectItem
        projectItem)
    {
    }

    public void RunFinished()
    {
    }

    public void RunStarted(object automationObject,
        Dictionary<string, string> replacementsDictionary,
        WizardRunKind runKind, object[] customParams)
    {
      try
      {
        inputForm = new UserInputForm();
        inputForm.ReplacementsDictionary = replacementsDictionary;
        inputForm.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    public bool ShouldAddProjectItem(string filePath)
    {
      return true;
    }
  }
}
