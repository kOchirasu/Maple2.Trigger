namespace Maple2.Trigger._52010038_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {6299}, arg2: false);
                context.ShadowExpedition(type: "CloseBossGauge");
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddBuff(arg1: new[] {199}, arg2: 70000109, arg3: 1, arg4: false, arg5: false);
                context.CreateMonster(arg1: new[] {1805, 1806, 1201}, arg2: false);
                context.SpawnNpcRange(rangeId: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new[] {1101, 1102, 1103, 1104, 1105, 1106}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new[] {1801, 1802, 1803, 1804}, isAutoTargeting: false);
                context.SetSkip(arg1: "시작");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetUserValue(triggerId: 999001, key: "GaugeOpen", value: 1);
                context.SetUserValue(triggerId: 992001, key: "WaveStart", value: 1);
                context.SetUserValue(triggerId: 999004, key: "AllertStart", value: 1);
            }

            public override void Execute() {
                if (context.GetShadowExpeditionPoints() >= 150) {
                    context.State = new State부상병발생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부상병발생 : TriggerState {
            internal State부상병발생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 7000, script: "$52010038_QD__main__4$", voice: @"ko/Npc/00002057");
                context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 1);
            }

            public override void Execute() {
                if (context.GetShadowExpeditionPoints() >= 300) {
                    context.State = new State2차폭탄방어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차폭탄방어 : TriggerState {
            internal State2차폭탄방어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 60, arg3: true, arg4: true, arg5: 80);
                context.SetUserValue(triggerId: 992003, key: "bombStart", value: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "연출02종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State카메라304(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라304 : TriggerState {
            internal State카메라304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetSkip(arg1: "연출02종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State부관대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부관대사03 : TriggerState {
            internal State부관대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "연출02종료");
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_surprise", msg: "$52010038_QD__MAIN__0$", duration: 7000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출02종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출02종료 : TriggerState {
            internal State연출02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSkip();
                context.SideNpcTalk(npcId: 11003537, illust: "Mason_closeEye", duration: 7000, script: "$52010038_QD__main__5$", voice: @"ko/Npc/00002095");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2008, 2009, 2010})) {
                    context.CreateMonster(arg1: new[] {4020, 4020}, arg2: false);
                    context.ResetTimer(arg1: "99");
                    context.State = new State2차폭탄방어완료조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차폭탄방어완료조건 : TriggerState {
            internal State2차폭탄방어완료조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2097})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 6000, script: "$52010038_QD__main__6$", voice: @"ko/Npc/00002106");
                    context.State = new State3층이벤트스킵(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3층이벤트스킵 : TriggerState {
            internal State3층이벤트스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetShadowExpeditionPoints() >= 700) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6201, 6202, 6203, 6204}, arg2: false);
                context.CreateMonster(arg1: new[] {2098}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "보스연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State카메라302(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라302 : TriggerState {
            internal State카메라302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetSkip(arg1: "보스연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State보스대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스대사01 : TriggerState {
            internal State보스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "보스연출종료");
                context.AddCinematicTalk(npcId: 11003185, illustId: "ShadowClaw_normal", msg: "$52010038_QD__MAIN__2$", duration: 5000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State보스이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스이동 : TriggerState {
            internal State보스이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "보스연출종료");
                context.MoveNpc(arg1: 2098, arg2: "MS2PatrolData_2098");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State카메라303(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라303 : TriggerState {
            internal State카메라303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003185, illustId: "ShadowClaw_normal", msg: "$52010038_QD__MAIN__3$", duration: 5000, align: "left");
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetSkip(arg1: "보스연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스연출종료 : TriggerState {
            internal State보스연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6299}, arg2: true);
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 7000, script: "$52010038_QD__main__8$", voice: @"ko/Npc/00002058");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {2098});
                context.CreateMonster(arg1: new[] {2099}, arg2: true);
                context.CreateMonster(arg1: new[] {1099}, arg2: false);
                context.SetUserValue(triggerId: 992001, key: "WaveSlowDown", value: 1);
                context.SetUserValue(triggerId: 992002, key: "WaveStart", value: 1);
            }

            public override void Execute() {
                if (context.GetShadowExpeditionPoints() >= 1000) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.SetUserValue(triggerId: 999001, key: "EngineIsDead", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}