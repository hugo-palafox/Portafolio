---
name: implementation-traceability
description: Use this skill on every development session to maintain breadcrumbs linking plan decisions, implementation changes, and next steps.
---

# Implementation Traceability and Work Breadcrumbs

## Use this skill when
- Planning, coding, or refactoring any feature.

## Required behaviors
1. Append each session to `DEVELOPMENT_LOG.md` with:
   - Date
   - Task performed
   - Files created or modified
   - Architectural decisions
   - Deviations from plan
   - Next recommended steps
2. Maintain `TASK_PROGRESS.md` with:
   - Planned tasks
   - Completed tasks
   - Current in-progress task
   - Next tasks
3. For each feature implementation:
   - Reference phase/task from the plan.
   - Document what was implemented.
   - Note deviations.
4. At milestone completion:
   - Summarize implemented scope, affected files, and remaining work.

## Rule
- Leave enough context so work can resume without deep code archaeology.

