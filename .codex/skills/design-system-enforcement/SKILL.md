---
name: design-system-enforcement
description: Use this skill to enforce spacing, typography, card, border, and accent consistency through shared design tokens and repeatable component patterns.
---

# Design System Enforcement

## Use this skill when
- Introducing or changing shared UI patterns.
- Reviewing style consistency across components and pages.

## Rules
- Use defined tokens; avoid arbitrary spacing and size values.
- Keep typography hierarchy consistent.
- Keep card styles consistent (padding, radius, border, elevation).
- Keep accent usage restrained and intentional.
- Extract recurring style patterns into reusable classes/components.

## Implementation guidance
- Centralize tokens in Tailwind config when practical.
- For complex repeated patterns, use semantic utility classes.

## Validation checklist
- Do all pages use the same spacing scale?
- Do headings/body/meta styles match hierarchy rules?
- Do cards look like one system, not many variants?

