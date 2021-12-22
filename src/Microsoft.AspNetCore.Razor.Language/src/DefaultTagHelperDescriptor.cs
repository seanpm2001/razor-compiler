// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using MessagePack;

namespace Microsoft.AspNetCore.Razor.Language;

[MessagePackObject]
public class DefaultTagHelperDescriptor : TagHelperDescriptor
{
    [SerializationConstructor]
    public DefaultTagHelperDescriptor(
        string kind,
        string name,
        string assemblyName,
        string displayName,
        string documentation,
        string tagOutputHint,
        bool caseSensitive,
        IReadOnlyList<TagMatchingRuleDescriptor> tagMatchingRules,
        IReadOnlyList<BoundAttributeDescriptor> attributeDescriptors,
        IReadOnlyList<AllowedChildTagDescriptor> allowedChildTags,
        IReadOnlyDictionary<string, string> metadata,
        IReadOnlyList<RazorDiagnostic> diagnostics)
        : base(kind)
    {
        Name = name;
        AssemblyName = assemblyName;
        DisplayName = displayName;
        Documentation = documentation;
        TagOutputHint = tagOutputHint;
        CaseSensitive = caseSensitive;
        TagMatchingRules = tagMatchingRules;
        BoundAttributes = attributeDescriptors;
        AllowedChildTags = allowedChildTags;
        Diagnostics = diagnostics;
        Metadata = metadata;
    }
}
