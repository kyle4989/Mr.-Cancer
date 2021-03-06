﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     코드가 다시 생성될 경우 이 파일이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface MoveableObject 
{
	string Code { get;set; }

	int HP { get;set; }

	Pixel Location { get;set; }

	string cellname { get;set; }

	bool Collided { get;set; }

	void LeftMove();

	void RightMove();

	void Disable();

	void Kill();

	void UpMove();

	void DownMove();

	void Stop();

	void IfCollision(MoveableObject Mo);

	void GiveSkill(Skill sk);

	void DeleteSkill(Skill sk);

	void EffectSkill(string code);

}

