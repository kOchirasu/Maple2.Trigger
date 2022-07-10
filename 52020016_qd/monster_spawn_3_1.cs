using System.Numerics;

namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_3_1 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn_phase_3") == 1) {
                    return new State전투Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Phase : TriggerState {
            internal State전투Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{4000201, 4000202}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000201, 4000202})) {
                    return new State전투Phase_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Phase_2 : TriggerState {
            internal State전투Phase_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{4000301}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State전투Phase_2_대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Phase_2_대사 : TriggerState {
            internal State전투Phase_2_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 4000301, script: "하하하!!내가 돌아왔다!", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "카...카트반? 어떻게?!", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000301})) {
                    return new State대화(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAmbientLight(color: default);
                context.SetDirectionalLight(diffuseColor: default, specularColor: default);
            }
        }

        private class State대화 : TriggerState {
            internal State대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
                context.SetConversation(type: 2, spawnId: 4000201, script: "제법이군요! 그렇다면 이건 어떤가요?", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조디Spawn_1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{4000401}, arg2: false);
            }
        }

        private class State조디Spawn_1 : TriggerState {
            internal State조디Spawn_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 4000401, patrolName: "MS2PatrolData0_4000401_1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조디Spawn_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(pathIds: new []{2000001}, returnView: false);
            }
        }

        private class State조디Spawn_2 : TriggerState {
            internal State조디Spawn_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 0, script: "!!!!!!!??????", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 0, script: "조...조디?!", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 0, script: "조디...살아있었던거야?", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 300001, script: "헤헤...오랫만에 뵙네요. 보고싶었어요.", arg4: 5);
                context.SetConversation(type: 2, spawnId: 300001, script: "그런데 저를...왜 죽게 내버려 두었나요?", arg4: 5);
                context.SetConversation(type: 2, spawnId: 0, script: "그...그게 아니야!!", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 300001, script: "당신을...저주해요..가만두지 않겠어요!!", arg4: 5);
                context.SetConversation(type: 2, spawnId: 0, script: "아...안돼 그만둬!! 조디!!", arg4: 3, arg5: 0);
                context.SetSkip(state: new State마지막전투(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new State마지막전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{4000401}, arg2: false);
                context.CameraSelectPath(pathIds: new []{2000001}, returnView: true);
            }
        }

        private class State마지막전투 : TriggerState {
            internal State마지막전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
                context.DestroyMonster(spawnIds: new []{4000401});
                context.SetEffect(triggerIds: new []{70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010, 70011, 70012, 70013, 70014, 70015, 70016, 70017, 70018, 70019, 70020, 70021, 70022, 70023, 70024}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마지막전투_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막전투_2 : TriggerState {
            internal State마지막전투_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(180f, 180f, 149f));
                context.SetDirectionalLight(diffuseColor: new Vector3(219f, 204f, 182f), specularColor: new Vector3(219f, 204f, 182f));
                context.SetPortal(portalId: 95, visible: true, enabled: true);
                context.SetUserValue(triggerId: 911, key: "respawn_phase_4", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000402})) {
                    return new State마지막전투_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막전투_3 : TriggerState {
            internal State마지막전투_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 912, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 913, key: "respawn_phase_4", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000403, 4000404})) {
                    return new State마지막전투_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막전투_4 : TriggerState {
            internal State마지막전투_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 914, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 915, key: "respawn_phase_4", value: 1);
                context.SetUserValue(triggerId: 916, key: "respawn_phase_4", value: 1);
                context.SetConversation(type: 1, spawnId: 0, script: "조디!! 제발 맘춰!!", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000405, 4000406, 4000407})) {
                    return new State마지막전투_5(context);
                }

                return null;
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

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000408, 4000409, 4000410, 4000411})) {
                    return new State긴급대화_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(type: "trigger", code: "DollMaster");
            }
        }

        private class State긴급대화_2 : TriggerState {
            internal State긴급대화_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Disappoint_A", "Emotion_Disappoint_Idle_A"});
                context.SetConversation(type: 1, spawnId: 0, script: "이젠...더이상은...힘들어....", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State긴급대화_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State긴급대화_3 : TriggerState {
            internal State긴급대화_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마지막_Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막_Cinematic : TriggerState {
            internal State마지막_Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{400001, 400002, 400003}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 400001, sequenceName: "Attack_Idle_A", duration: 99999999f);
                context.SetNpcEmotionLoop(spawnId: 400002, sequenceName: "Attack_Idle_A", duration: 99999999f);
                context.SetNpcEmotionLoop(spawnId: 400003, sequenceName: "Attack_Idle_A", duration: 99999999f);
                context.MoveUser(mapId: 52020016, portalId: 97);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마지막_Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetPcEmotionLoop(sequenceName: "Emotion_Disappoint_Idle_A", duration: 99999999f);
            }
        }

        private class State마지막_Cinematic_2 : TriggerState {
            internal State마지막_Cinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelectPath(pathIds: new []{2000005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마지막_Cinematic_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막_Cinematic_3 : TriggerState {
            internal State마지막_Cinematic_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{320001}, arg2: false);
                context.MoveNpc(spawnId: 320001, patrolName: "MS2PatrolData0_320001_1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마지막_Cinematic_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막_Cinematic_4 : TriggerState {
            internal State마지막_Cinematic_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 320001, script: "하하하하! 느껴지시나요? 나와 당신의 높이가!!", arg4: 5);
                context.SetConversation(type: 2, spawnId: 0, script: "헉헉...제발 그만둬!!", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 320001, script: "이 몽환의 무대 안에서는 어떠한 존재라도 저를 이길 수 없습니다!", arg4: 5);
                context.SetConversation(type: 2, spawnId: 320001, script: "그럼 이제 마무리를 지어 볼까요?", arg4: 5);
                context.SetSkip(state: new State마지막_Cinematic_4_2(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new State마지막_Cinematic_4_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막_Cinematic_4_2 : TriggerState {
            internal State마지막_Cinematic_4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2000006}, returnView: false);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State마지막_Cinematic_4_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막_Cinematic_4_3 : TriggerState {
            internal State마지막_Cinematic_4_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{410001, 410002, 410003, 410004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State마지막_Cinematic_5(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{420001, 420002, 420003, 420004, 420005, 420006, 420007}, arg2: false);
            }
        }

        private class State마지막_Cinematic_5 : TriggerState {
            internal State마지막_Cinematic_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020032, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
