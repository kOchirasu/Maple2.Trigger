using System;
using System.Numerics;

namespace Maple2.Trigger._02000543_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(17f, 196f, 181f), arg2: new Vector3(0f, 0f, 0f));
                context.SetMesh(arg1: new int[] {5000, 5001}, arg2: true);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.SetEffect(arg1: new int[] {3000}, arg2: false);
                context.SetEffect(arg1: new int[] {3002}, arg2: false);
                context.SetEffect(arg1: new int[] {3001}, arg2: false);
                context.SetEffect(arg1: new int[] {3003}, arg2: false);
                context.SetEffect(arg1: new int[] {3004}, arg2: false);
                context.SetEffect(arg1: new int[] {3005}, arg2: false);
                context.SetSkill(arg1: new int[] {4000}, arg2: false);
                context.SetSkill(arg1: new int[] {4001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 106, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {703}, arg2: 0)) {
                    context.State = new State뒤큐브날리기전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뒤큐브날리기전 : TriggerState {
            internal State뒤큐브날리기전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {4000}, arg2: true);
                context.CreateMonster(arg1: new int[] {104, 105, 110}, arg2: false);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State뒤큐브날리기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뒤큐브날리기 : TriggerState {
            internal State뒤큐브날리기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {3001}, arg2: true);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 3000,
                    script: "$02000543_BF__MAIN__0$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {701}, arg2: 0)) {
                    context.State = new State게임안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임안내 : TriggerState {
            internal State게임안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {7000}, arg2: false);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 3000,
                    script: "$02000543_BF__MAIN__1$");
                context.LockMyPc(isLock: true);
                context.SetMesh(arg1: new int[] {5000, 5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State게임안내2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임안내2 : TriggerState {
            internal State게임안내2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {7000}, arg2: true);
                context.LockMyPc(isLock: false);
                context.AddBalloonTalk(spawnPointID: 104, msg: "$02000543_BF__MAIN__2$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 105, msg: "$02000543_BF__MAIN__3$", duration: 3500,
                    delayTick: 500);
                context.CreateMonster(arg1: new int[] {107}, arg2: true);
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카메라리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋 : TriggerState {
            internal State카메라리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
                context.CreateMonster(arg1: new int[] {112}, arg2: false);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000543_BF__MAIN__4$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State게임설정(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임설정 : TriggerState {
            internal State게임설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 4000,
                    script: "$02000543_BF__MAIN__5$");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(arg1: new int[] {3002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State조건체크몬스터스폰1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건체크몬스터스폰1 : TriggerState {
            internal State조건체크몬스터스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {110});
                context.SetEventUI(arg1: 1, arg2: "$02000543_BF__MAIN__6$", arg3: new int[] {3000});
                context.SetOnetimeEffect(id: 104, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.UserValue(key: "main", value: 4)) {
                    context.State = new State조건체크몬스터스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건체크몬스터스폰2 : TriggerState {
            internal State조건체크몬스터스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State조건체크몬스터스폰3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건체크몬스터스폰3 : TriggerState {
            internal State조건체크몬스터스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {108}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {108})) {
                    context.State = new State2단계가기전1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계가기전1 : TriggerState {
            internal State2단계가기전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State2단계가기전2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계가기전2 : TriggerState {
            internal State2단계가기전2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000543_BF__MAIN__7$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAiExtraData(key: "phaseSecond", value: 1);
                    context.State = new State2단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계 : TriggerState {
            internal State2단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {3000}, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "main", value: 5)) {
                    context.State = new State2단계시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계시작 : TriggerState {
            internal State2단계시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State2단계조건체크몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계조건체크몬스터 : TriggerState {
            internal State2단계조건체크몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {109}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 107, msg: "$02000543_BF__MAIN__8$", duration: 3500,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {109})) {
                    context.State = new State3단계시작전1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3단계시작전1 : TriggerState {
            internal State3단계시작전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State3단계시작전2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3단계시작전2 : TriggerState {
            internal State3단계시작전2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAiExtraData(key: "phaseSecond", value: 5);
                    context.SetAiExtraData(key: "phase", value: 5);
                    context.State = new State3단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3단계 : TriggerState {
            internal State3단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000543_BF__MAIN__9$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State조건체크몬스터스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건체크몬스터스폰 : TriggerState {
            internal State조건체크몬스터스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 4000,
                    script: "$02000543_BF__MAIN__10$");
            }

            public override void Execute() {
                if (context.UserValue(key: "main", value: 8)) {
                    context.State = new State응접실문열기전몬스터스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State응접실문열기전몬스터스폰 : TriggerState {
            internal State응접실문열기전몬스터스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102})) {
                    context.State = new State응접실문대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State응접실문대기 : TriggerState {
            internal State응접실문대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(201f, 38f, 70f), arg2: new Vector3(0f, 0f, 0f));
                context.SetOnetimeEffect(id: 106, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000543_BF__MAIN__11$", arg3: new int[] {3000});
                context.DestroyMonster(arg1: new int[] {106, 107});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State응접실문열기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State응접실문열기1 : TriggerState {
            internal State응접실문열기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {3003}, arg2: true);
                context.LockMyPc(isLock: true);
                context.SideNpcTalk(npcID: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 3000,
                    script: "$02000543_BF__MAIN__12$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State응접실문열기11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State응접실문열기11 : TriggerState {
            internal State응접실문열기11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {3000}, arg2: false);
                context.SetEffect(arg1: new int[] {3002}, arg2: false);
                context.SetEffect(arg1: new int[] {3004}, arg2: true);
                context.SetEffect(arg1: new int[] {3005}, arg2: true);
                context.SideNpcTalk(npcID: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 4000,
                    script: "$02000543_BF__MAIN__13$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State응접실문열기31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State응접실문열기31 : TriggerState {
            internal State응접실문열기31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000543_BF__MAIN__14$", arg3: new int[] {3000});
                context.DestroyMonster(arg1: new int[] {111, 112});
                context.SetEffect(arg1: new int[] {3004}, arg2: false);
                context.SetEffect(arg1: new int[] {3005}, arg2: false);
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State응접실문열기4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State응접실문열기4 : TriggerState {
            internal State응접실문열기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetSkill(arg1: new int[] {4001}, arg2: true);
                context.SetEffect(arg1: new int[] {3003}, arg2: false);
                context.AddBalloonTalk(spawnPointID: 104, msg: "$02000543_BF__MAIN__15$", duration: 3500);
                context.AddBalloonTalk(spawnPointID: 105, msg: "$02000543_BF__MAIN__16$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State응접실문열고나서처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State응접실문열고나서처리 : TriggerState {
            internal State응접실문열고나서처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000543_BF__MAIN__17$");
                context.DestroyMonster(arg1: new int[] {104, 105});
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {702}, arg2: 0)) {
                    context.State = new State보스스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스스폰 : TriggerState {
            internal State보스스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보스스폰2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스스폰2 : TriggerState {
            internal State보스스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103})) {
                    context.State = new State포탈열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈열기 : TriggerState {
            internal State포탈열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}