using Microsoft.AspNetCore.Identity;

namespace CMSMicroservice.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        // Fecha en la que el usuario se registró en la plataforma
        public DateTime RegistrationDate { get; set; }

        // URL o referencia al avatar del usuario
        public string AvatarUrl { get; set; }

        // Dirección de correo electrónico adicional
        public string AdditionalEmail { get; set; }

        // Número de teléfono del usuario
        public string PhoneNumber { get; set; }

        // Preferencias de visualización, idioma, tema, etc.
        public string DisplayPreferences { get; set; }

        // Roles específicos de la aplicación
        public string CustomRole { get; set; }

        // Fecha y hora de la última actividad del usuario en la plataforma
        public DateTime LastActivity { get; set; }

        // Ubicación geográfica del usuario
        public string Location { get; set; }
    }
}