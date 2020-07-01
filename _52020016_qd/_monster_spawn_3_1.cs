using System.Numerics;

namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_3_1 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "respawn_phase_3") == 1) {
                    context.State = new State전투페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투페이즈 : TriggerState {
            internal State전투페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4000201}, arg2: false);
                context.CreateMonster(arg1: new[] {4000202}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {4000201}) && context.MonsterDead(arg1: new[] {4000202})) {
                    context.State = new State전투페이즈_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투페이즈_2 : TriggerState {
            internal State전투페이즈_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4000301}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State전투페이즈_2_대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투페이즈_2_대사 : TriggerState {
            internal State전투페이즈_2_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 4000301, arg3: "하하하!!내가 돌아왔다!", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "카...카트반? 어떻게?!", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {4000301})) {
                    context.State = new State대화(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(0f, 0f, 0f));
            }
        }

        private class State대화 : TriggerState {
            internal State대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.SetConversation(arg1: 2, arg2: 4000201, arg3: "제법이군요! 그렇다면 이건 어떤가요?", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조디등장_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {4000401}, arg2: false);
            }
        }

        private class State조디등장_1 : TriggerState {
            internal State조디등장_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 4000401, arg2: "MS2PatrolData0_4000401_1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조디등장_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new[] {2000001}, arg2: false);
            }
        }

        private class State조디등장_2 : TriggerState {
            internal State조디등장_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 0, arg3: "!!!!!!!??????", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 0, arg3: "조...조디?!", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 0, arg3: "조디...살아있었던거야?", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 300001, arg3: "헤헤...오랫만에 뵙네요. 보고싶었어요.", arg4: 5);
                context.SetConversation(arg1: 2, arg2: 300001, arg3: "그런데 저를...왜 죽게 내버려 두었나요?", arg4: 5);
                context.SetConversation(arg1: 2, arg2: 0, arg3: "그...그게 아니야!!", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 300001, arg3: "당신을...저주해요..가만두지 않겠어요!!", arg4: 5);
                context.SetConversation(arg1: 2, arg2: 0, arg3: "아...안돼 그만둬!! 조디!!", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "마지막전투");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    context.State = new State마지막전투(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {4000401}, arg2: false);
                context.CameraSelectPath(arg1: new[] {2000001}, arg2: true);
            }
        }

        private class State마지막전투 : TriggerState {
            internal State마지막전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.DestroyMonster(arg1: new[] {4000401});
                context.SetEffect(
                    arg1: new[] {
                        70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010, 70011, 70012, 70013,
                        70014, 70015, 70016, 70017, 70018, 70019, 70020, 70021, 70022, 70023, 70024
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State마지막전투_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막전투_2 : TriggerState {
            internal State마지막전투_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(180f, 180f, 149f));
                context.SetDirectionalLight(arg1: new Vector3(219f, 204f, 182f), arg2: new Vector3(219f, 204f, 182f));
                context.SetPortal(arg1: 95, arg2: true, arg3: true);
                context.SetUserValue(triggerId: 911, key: "respawn_phase_4", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {4000402})) {
                    context.State = new State마지막전투_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막전투_3 : TriggerState {
            internal State마지막전투_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 912, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 913, key: "respawn_phase_4", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {4000403}) && context.MonsterDead(arg1: new[] {4000404})) {
                    context.State = new State마지막전투_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막전투_4 : TriggerState {
            internal State마지막전투_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 914, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 915, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 916, key: "respawn_phase_4", value: 1);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "조디!! 제발 맘춰!!", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {4000405})
                    && context.MonsterDead(arg1: new[] {4000406})
                    && context.MonsterDead(arg1: new[] {4000407})) {
                    context.State = new State마지막전투_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막전투_5 : TriggerState {
            internal State마지막전투_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 917, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 918, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 919, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 920, key: "respawn_phase_4", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {4000408})
                    && context.MonsterDead(arg1: new[] {4000409})
                    && context.MonsterDead(arg1: new[] {4000410})
                    && context.MonsterDead(arg1: new[] {4000411})) {
                    context.State = new State긴급대화_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg2: "trigger", arg3: "DollMaster");
            }
        }

        private class State긴급대화_2 : TriggerState {
            internal State긴급대화_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.SetPcEmotionSequence(arg1: "Emotion_Disappoint_A,Emotion_Disappoint_Idle_A");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "이젠...더이상은...힘들어....", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State긴급대화_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State긴급대화_3 : TriggerState {
            internal State긴급대화_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마지막_연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막_연출 : TriggerState {
            internal State마지막_연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {400001}, arg2: false);
                context.CreateMonster(arg1: new[] {400002}, arg2: false);
                context.CreateMonster(arg1: new[] {400003}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 400001, arg2: "Attack_Idle_A", arg3: 99999999f);
                context.SetNpcEmotionLoop(arg1: 400002, arg2: "Attack_Idle_A", arg3: 99999999f);
                context.SetNpcEmotionLoop(arg1: 400003, arg2: "Attack_Idle_A", arg3: 99999999f);
                context.MoveUser(arg1: 52020016, arg2: 97);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State마지막_연출_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetPcEmotionLoop(arg1: "Emotion_Disappoint_Idle_A", arg2: 99999999f);
            }
        }

        private class State마지막_연출_2 : TriggerState {
            internal State마지막_연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelectPath(arg1: new[] {2000005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마지막_연출_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막_연출_3 : TriggerState {
            internal State마지막_연출_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {320001}, arg2: false);
                context.MoveNpc(arg1: 320001, arg2: "MS2PatrolData0_320001_1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State마지막_연출_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막_연출_4 : TriggerState {
            internal State마지막_연출_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 320001, arg3: "하하하하! 느껴지시나요? 나와 당신의 높이가!!", arg4: 5);
                context.SetConversation(arg1: 2, arg2: 0, arg3: "헉헉...제발 그만둬!!", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 320001, arg3: "이 몽환의 무대 안에서는 어떠한 존재라도 저를 이길 수 없습니다!", arg4: 5);
                context.SetConversation(arg1: 2, arg2: 320001, arg3: "그럼 이제 마무리를 지어 볼까요?", arg4: 5);
                context.SetSkip(arg1: "마지막_연출_4_2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    context.State = new State마지막_연출_4_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막_연출_4_2 : TriggerState {
            internal State마지막_연출_4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2000006}, arg2: false);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new State마지막_연출_4_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막_연출_4_3 : TriggerState {
            internal State마지막_연출_4_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {410001}, arg2: false);
                context.CreateMonster(arg1: new[] {410002}, arg2: false);
                context.CreateMonster(arg1: new[] {410003}, arg2: false);
                context.CreateMonster(arg1: new[] {410004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new State마지막_연출_5(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {420001}, arg2: false);
                context.CreateMonster(arg1: new[] {420002}, arg2: false);
                context.CreateMonster(arg1: new[] {420003}, arg2: false);
                context.CreateMonster(arg1: new[] {420004}, arg2: false);
                context.CreateMonster(arg1: new[] {420005}, arg2: false);
                context.CreateMonster(arg1: new[] {420006}, arg2: false);
                context.CreateMonster(arg1: new[] {420007}, arg2: false);
            }
        }

        private class State마지막_연출_5 : TriggerState {
            internal State마지막_연출_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 4);
            }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020032, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) { }
            }

            public override void OnExit() { }
        }
    }
}