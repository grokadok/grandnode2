using Grand.Domain.Directory;
using Grand.Domain.Localization;

namespace Grand.Domain.Shipping;

/// <summary>
///     Represents a shipping method (used for offline Shipping rate  methods)
/// </summary>
public class ShippingMethod : BaseEntity, ITranslationEntity
{
    private ICollection<Country> _restrictedCountries;
    private ICollection<string> _restrictedGroups;

    /// <summary>
    ///     Gets or sets the name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Gets or sets the description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    ///     Gets or sets the display order
    /// </summary>
    public int DisplayOrder { get; set; }

    /// <summary>
    ///     Gets or sets the restricted countries
    /// </summary>
    public virtual ICollection<Country> RestrictedCountries {
        get => _restrictedCountries ??= new List<Country>();
        protected set => _restrictedCountries = value;
    }

    /// <summary>
    ///     Gets or sets the restricted roles
    /// </summary>
    public virtual ICollection<string> RestrictedGroups {
        get => _restrictedGroups ??= new List<string>();
        protected set => _restrictedGroups = value;
    }

    /// <summary>
    ///     Gets or sets the collection of locales
    /// </summary>
    public IList<TranslationEntity> Locales { get; set; } = new List<TranslationEntity>();
}