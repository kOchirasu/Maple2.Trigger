using System;

namespace Maple2.Trigger._52020024_qd {
    public static class _52020024_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State감지(context);

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990002, key: "TimerStart", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "FinalPhase", value: 0);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetActor(arg1: 10001, arg2: true, arg3: "ks_quest_movewall_A02_off");
                context.SetActor(arg1: 10002, arg2: true, arg3: "ks_quest_movewall_A02_off");
                context.SetActor(arg1: 10003, arg2: true, arg3: "ks_quest_fusiondevice_A01_off");
                context.SetMesh(arg1: new int[] {1001}, arg2: true);
                context.SetMesh(arg1: new int[] {2001}, arg2: true);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10002006}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10002007}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10002008}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10002009}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "901")) {
                    context.State = new State1차전투감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투감지 : TriggerState {
            internal State1차전투감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "902")) {
                    context.State = new State1차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투 : TriggerState {
            internal State1차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "방 안을 수색하세요", arg3: new int[] {5000}, arg4: "0");
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102, 103}, arg2: false)) {
                    context.State = new State1번레버활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번레버활성화 : TriggerState {
            internal State1번레버활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002006}, arg2: 1);
                context.AddBalloonTalk(spawnPointID: 0, msg: "파편 융합 장치 전원을 찾아야해", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002006}, arg2: 0)) {
                    context.State = new State2차전투감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투감지 : TriggerState {
            internal State2차전투감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1001}, arg2: false, arg3: 500);
                context.SetActor(arg1: 10001, arg2: true, arg3: "ks_quest_movewall_A02_start");
                context.AddBalloonTalk(spawnPointID: 0, msg: "헐... 대박...", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "903")) {
                    context.State = new State2차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111, 112}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {111, 112}, arg2: false)) {
                    context.State = new State2번레버활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번레버활성화 : TriggerState {
            internal State2번레버활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "여기엔 없는것 같네", duration: 3000, delayTick: 0);
                context.SetInteractObject(arg1: new int[] {10002007}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002007}, arg2: 0)) {
                    context.State = new State3차전투감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투감지 : TriggerState {
            internal State3차전투감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {2001}, arg2: false, arg3: 500);
                context.SetActor(arg1: 10002, arg2: true, arg3: "ks_quest_movewall_A02_start");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "904")) {
                    context.State = new State3차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투 : TriggerState {
            internal State3차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {121, 122}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {121, 122}, arg2: false)) {
                    context.State = new State3번레버활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번레버활성화 : TriggerState {
            internal State3번레버활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002008}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002008}, arg2: 0)) {
                    context.State = new State파편모으기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파편모으기 : TriggerState {
            internal State파편모으기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002009}, arg2: 1);
                context.AddBalloonTalk(spawnPointID: 0, msg: "중앙으로 가보자!", duration: 3000, delayTick: 0);
                context.SetEventUI(arg1: 1, arg2: "융합장치 전원 활성화.", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002009}, arg2: 0)) {
                    context.State = new State파이널전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파이널전투 : TriggerState {
            internal State파이널전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 10003, arg2: true, arg3: "ks_quest_fusiondevice_A01_on");
                context.SetUserValue(triggerID: 99990002, key: "TimerStart", value: 1);
                context.SetUserValue(triggerID: 99990003, key: "FinalPhase", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 2)) {
                    context.State = new State파편합성완료(context);
                    return;
                }

                if (context.UserValue(key: "FinalPhase", value: 2)) {
                    context.State = new State파편합성완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State파편합성완료 : TriggerState {
            internal State파편합성완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 10003, arg2: true, arg3: "ks_quest_fusiondevice_A01_off");
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_미카엘등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_미카엘등장 : TriggerState {
            internal State카메라_미카엘등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카메라_종료", arg2: "exit");
                context.MoveUser(arg1: 52020024, arg2: 2);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_Michael");
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라_미카엘대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_미카엘대사1 : TriggerState {
            internal State카메라_미카엘대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "아주 좋아!", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카메라_미카엘대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_미카엘대사2 : TriggerState {
            internal State카메라_미카엘대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "파편이 어쩌구~ 저쩌구~", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카메라_지진사태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_지진사태 : TriggerState {
            internal State카메라_지진사태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 503, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "왜...왜 이러지?", arg4: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG\Common\Eff_Com_Vibrate_Lowamp.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_바닥부서짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_바닥부서짐 : TriggerState {
            internal State카메라_바닥부서짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "으아아악!!!", arg4: 2);
                context.CameraSelect(arg1: 504, arg2: true);
                context.SetSkill(arg1: new int[] {1}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_종료 : TriggerState {
            internal State카메라_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020025, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}