#pragma once
#ifndef _WRAPPER_
#define _WRAPPER_

#include "PluginSettings.h"
#include "Vector2D.h"

#ifdef __cplusplus
extern "C"
{
#endif
	PLUGIN_API int GetID();
	PLUGIN_API void SetID(int id);
	PLUGIN_API Vector2D GetPosition();
	PLUGIN_API void SetPosition(float x, float y);
#ifdef __cplusplus
}
#endif

#endif /*defined (_WRAPPER_)*/