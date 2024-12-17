namespace OrderManagementSystem.Utilities;

// Utility class for validations
public static class Validator
{
    public static void ValidateNotNull(object obj, string errorMessage)
    {
        if (obj == null)
            throw new ArgumentNullException(errorMessage);
    }
}
