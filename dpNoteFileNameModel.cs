using System;

public class dpNoteFileNameModel
{

    private string _mFileName;
    private string _mPassword;

    public string mFileName
    {
        get { return _mFileName; }
        set
        {
            if (!_mFileName.Equals(value))
                _mFileName = value;
        }
    }

    public string mPassword
    {
        get { return _mPassword; }
        set
        {
            if (!_mPassword.Equals(value))
                _mPassword = value;
        }

    }

    public dpNoteFileNameModel()
	{
	}
}
