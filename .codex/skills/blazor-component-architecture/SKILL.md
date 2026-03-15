---
name: blazor-component-architecture
description: Apply this skill for Blazor UI implementation to enforce small reusable Razor components, clean composition, and readable markup/logic separation.
---

# Blazor Component Architecture

## Use this skill when
- Building or refactoring Razor components and pages.

## Component design rules
- Prefer small focused components over monoliths.
- Give each component one clear responsibility.
- Use descriptive parameters for reuse.
- Keep markup declarative and readable.

## @code block order
1. Parameters
2. Injected services
3. Local state
4. Lifecycle methods
5. Event handlers
6. Helper methods

## Additional rules
- Move complex logic out of markup into helper methods.
- Prefer simple local state in Phase 1.
- Avoid global state libraries in Phase 1.
- Use `@key` for list rendering where appropriate.

## Validation checklist
- Is component scope clear and reusable?
- Is markup readable without heavy inline logic?
- Are component APIs simple and predictable?

