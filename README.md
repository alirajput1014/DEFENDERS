# DEFENDERS

A Unity game project maintained as a clean, cloneable Git repository.

## Project Overview

- Engine: Unity 6000.0.41f1
- Source assets: Assets/
- Package manifest: Packages/manifest.json
- Project settings: ProjectSettings/

## Repository Setup

This repository is configured for Unity development:

- Unity-generated folders such as Library/, Temp/, Logs/, Obj/, and build outputs are ignored.
- Large binary assets are tracked with Git LFS.
- Unity .meta files are preserved to keep asset references stable.

## Clone Instructions

Install Git LFS before cloning:

`powershell
git lfs install
git clone <repository-url>
`

Open the cloned folder with Unity 6000.0.41f1 or a compatible Unity Editor version.

## Development Notes

- Commit source files, scenes, prefabs, scripts, package files, and project settings.
- Do not commit generated Unity cache folders or local IDE files.
- Keep asset .meta files together with their matching assets.
